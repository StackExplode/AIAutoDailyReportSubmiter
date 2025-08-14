using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.AI;
internal class AIChatRequest
{
    public string model { get; set; }
    public List<AIChatMessage> messages { get; set; } = new();
    public float temperature { get; set; } = 0.7f;

}

