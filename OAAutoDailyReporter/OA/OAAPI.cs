using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.OA;
internal class OAAPI
{
    public static readonly string BaseUrl = "http://www.njust-lyw.com:60098/";
    public static readonly string LoginPath = "prod-api/login";
    public static readonly string DailyReportPath = "prod-api/workReport/workReport";

    public async Task<int> Login(User user)
    {
        string json = JsonConvert.SerializeObject(user);
        string rt = await Helper.HttpHelper.PostJSON(BaseUrl + LoginPath, json);
        dynamic obj = JsonConvert.DeserializeObject<dynamic>(rt)!;
        user.AuthToken = obj.token;
        return obj.code;
    }

    public async Task<int> SubmitDailyReport(DailyReport report, User user)
    {
        string json = JsonConvert.SerializeObject(report);
        string rt = await Helper.HttpHelper.PostJSON(BaseUrl + DailyReportPath, json, user.BearerToken);
        dynamic obj = JsonConvert.DeserializeObject<dynamic>(rt)!;
        return obj.code;
    }
}
