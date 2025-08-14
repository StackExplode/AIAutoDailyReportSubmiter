using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.OA;
internal class User
{
    public string username { get; set; }
    public string password { get; set; }

    [JsonIgnore]
    public string AuthToken { get; set; }

    [JsonIgnore]
    public string BearerToken => "Bearer " + AuthToken;
}
