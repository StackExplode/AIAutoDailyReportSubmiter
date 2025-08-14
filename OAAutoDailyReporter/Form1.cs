using Newtonsoft.Json;
using OAAutoDailyReporter.AI;
using OAAutoDailyReporter.OA;

namespace OAAutoDailyReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            config.LoadFromFile("config.json");
            txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_project.Text = config.DefaultProject;
            Log($"配置文件加载成功！用户名=\"{config.Username}\"");
        }

        private void Log(string message)
        {
            string msg = $"[{DateTime.Now:HH:mm:ss}] {message}";
            textBox1.AppendText(msg + Environment.NewLine);
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        Config config = new Config();

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Log("开始生成日报...");
            button1.Enabled = false;
            AIAPI ai = new AIAPI(config.AIBaseUrl, config.AIToken, config.AIModel);
            string content = txt_content.Text;
            if (checkBox1.Checked)
            {
                content = string.Format(content, txt_val.Lines);
            }
            string aicontent = string.Format(config.AITemplate, txt_project.Text, content);
            Log($"正在请求AI生成内容(模型：{config.AIModel}，温度：{config.AITemprature})...");
            Log("AI生成速度较慢，请耐心等待...");
            var response = await ai.Chat(config.AIHint, aicontent, config.AITempratureVal);
            string result = response.FirstMessage;
            Log($"AI内容生成成功！其内容为：{result}");
            dynamic result_jsonobj = JsonConvert.DeserializeObject<dynamic>(result)!;
            Log($"花费Token总数： {response.usage.total_tokens}");

            DailyReport report = new DailyReport()
            {
                reportDate = txt_date.Text,
                projectId = txt_project.Text,
                projectProgress = result_jsonobj.projectProgress,
                problemFeedback = result_jsonobj.problemFeedback,
                projectCompletionRate = int.Parse(txt_prog.Text),
                workingOurs = int.Parse(txt_our.Text),
            };

            User user = new User()
            {
                username = config.Username,
                password = config.Password
            };
            OAAPI oa = new OAAPI();

            Log("正在登录OA系统...");
            int login_code = await oa.Login(user);
            if (login_code != 200)
            {
                Log($"登录失败！错误代码：{login_code}");
                button1.Enabled = true;
                return;
            }
            Log("登录成功！正在提交日报...");
            int submit_code = await oa.SubmitDailyReport(report, user);
            if (submit_code != 200)
            {
                Log($"提交失败！错误代码：{submit_code}");
                button1.Enabled = true;
                return;
            }
            Log("日报提交成功！");
            button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_val.Enabled = checkBox1.Checked;
        }
    }
}
