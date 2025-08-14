using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter;
internal class Config
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string DefaultProject { get; set; }
    public string AIBaseUrl { get; set; }
    public string AIToken { get; set; }
    public string AIModel { get; set; }
    public string AIHint { get; set; }
    public string AITemplate { get; set; }

    public string AITemprature { get; set; }

    public float AITempratureVal => float.TryParse(AITemprature, out float val) ? val : 0.7f;

    public void LoadFromFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("Configuration file not found.", path);
        }
        string text = File.ReadAllText(path, Encoding.UTF8);
        dynamic obj = JsonConvert.DeserializeObject<dynamic>(text)!;
        //Get all properties of this class and fill value wihe the same name in the json object
        foreach (var prop in this.GetType().GetProperties())
        {
            if (obj[prop.Name] != null)
            {
                prop.SetValue(this, obj[prop.Name].ToString());
            }
        }
    }
}
