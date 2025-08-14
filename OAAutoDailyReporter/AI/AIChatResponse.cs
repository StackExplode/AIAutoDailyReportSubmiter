using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.AI;
internal class AIChatResponse
{
    public string id { get; set; } = string.Empty;
    public string @object { get; set; } = string.Empty;
    public int created { get; set; }
    public string model { get; set; } = string.Empty;
    public AIChatUsage usage {get; set;}
    public List<AIChatChoice> choices { get; set; } = new List<AIChatChoice>();

    public string FirstMessage =>
        choices.Count > 0 && choices[0].message != null ?
        choices[0].message.content : string.Empty;
}

internal class AIChatChoice
{
    public int index { get; set; }
    public AIChatMessage message { get; set; } = new AIChatMessage();
    public string finish_reason { get; set; } = string.Empty;
}

internal class AIChatMessage
{
    public AIChatMessage(string content,string role = "user")
    {
        this.role = role; // Default role
        this.content = content;
    }
    public AIChatMessage() { }
    public string role { get; set; } = string.Empty;
    public string content { get; set; } = string.Empty;
}

internal class AIChatUsage
{
    public int prompt_tokens { get; set; }
    public int completion_tokens { get; set; }
    public int total_tokens { get; set; }
}


