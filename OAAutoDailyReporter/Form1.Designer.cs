namespace OAAutoDailyReporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            txt_project = new TextBox();
            label3 = new Label();
            txt_date = new TextBox();
            label4 = new Label();
            txt_prog = new TextBox();
            label5 = new Label();
            txt_our = new TextBox();
            label6 = new Label();
            txt_content = new TextBox();
            txt_val = new TextBox();
            checkBox1 = new CheckBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 238);
            button1.Name = "button1";
            button1.Size = new Size(412, 32);
            button1.TabIndex = 0;
            button1.Text = "一键生成并自动提交日报";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 276);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(412, 273);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "日报类型：";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(90, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "业务日报";
            toolTip1.SetToolTip(textBox2, "当前仅支持“业务日报”");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "项目名称：";
            // 
            // txt_project
            // 
            txt_project.Location = new Point(90, 40);
            txt_project.Name = "txt_project";
            txt_project.Size = new Size(150, 23);
            txt_project.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 43);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "填写日期：";
            // 
            // txt_date
            // 
            txt_date.Location = new Point(324, 40);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(100, 23);
            txt_date.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 9);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "进度(%)：";
            // 
            // txt_prog
            // 
            txt_prog.Location = new Point(274, 6);
            txt_prog.Name = "txt_prog";
            txt_prog.Size = new Size(46, 23);
            txt_prog.TabIndex = 3;
            txt_prog.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 9);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 2;
            label5.Text = "工时：";
            // 
            // txt_our
            // 
            txt_our.Location = new Point(378, 6);
            txt_our.Name = "txt_our";
            txt_our.Size = new Size(46, 23);
            txt_our.TabIndex = 3;
            txt_our.Text = "8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 73);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 2;
            label6.Text = "工作描述：";
            // 
            // txt_content
            // 
            txt_content.Location = new Point(12, 91);
            txt_content.Multiline = true;
            txt_content.Name = "txt_content";
            txt_content.Size = new Size(228, 141);
            txt_content.TabIndex = 4;
            txt_content.Text = "我今天做了：{0}。结果：{1}";
            // 
            // txt_val
            // 
            txt_val.Location = new Point(246, 91);
            txt_val.Multiline = true;
            txt_val.Name = "txt_val";
            txt_val.Size = new Size(178, 141);
            txt_val.TabIndex = 4;
            txt_val.Text = "电机维护调试\r\n遇到了一些问题但可以解决";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(246, 72);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(195, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "模板插值（按顺序一行一个）";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 40;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 561);
            Controls.Add(checkBox1);
            Controls.Add(txt_val);
            Controls.Add(txt_content);
            Controls.Add(txt_our);
            Controls.Add(txt_prog);
            Controls.Add(txt_date);
            Controls.Add(txt_project);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "AI自动日报生成器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox txt_project;
        private Label label3;
        private TextBox txt_date;
        private Label label4;
        private TextBox txt_prog;
        private Label label5;
        private TextBox txt_our;
        private Label label6;
        private TextBox txt_content;
        private TextBox txt_val;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
    }
}
