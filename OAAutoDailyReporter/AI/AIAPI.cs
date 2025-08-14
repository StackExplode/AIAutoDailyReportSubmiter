using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.AI;
internal class AIAPI
{
    public string BaseUrl { get; set; }
    public string Token { get; set; }
    public string Model { get; set; }
    public AIAPI(string baseUrl, string token, string model)
    {
        BaseUrl = baseUrl;
        Token = token;
        Model = model;
    }

    public async Task<AIChatResponse> Chat(string massage, float temprature = 0.7f)
    {
        AIChatRequest req = new AIChatRequest()
        {
            model = Model,
            temperature = temprature
        };
        req.messages.Add(new AIChatMessage(massage, "user"));
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(req);
        string rt = await Helper.HttpHelper.PostJSON(BaseUrl, json, "Bearer " + Token);
        AIChatResponse? response = Newtonsoft.Json.JsonConvert.DeserializeObject<AIChatResponse>(rt);
        if (response == null)
        {
            throw new Exception("AI response is null");
        }
        return response;
    }

    public async Task<AIChatResponse> Chat(string hint, string massage, float temprature = 0.7f)
    {
        AIChatRequest req = new AIChatRequest()
        {
            model = Model,
            temperature = temprature
        };
        req.messages.Add(new AIChatMessage(hint, "system"));
        req.messages.Add(new AIChatMessage(massage,"user"));
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(req);
        string rt = await Helper.HttpHelper.PostJSON(BaseUrl, json, "Bearer " + Token);
        AIChatResponse? response = Newtonsoft.Json.JsonConvert.DeserializeObject<AIChatResponse>(rt);
        if (response == null)
        {
            throw new Exception("AI response is null");
        }
        return response;
    }
}
