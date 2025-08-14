using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAAutoDailyReporter.OA;
internal class DailyReport
{
    public DailyReport()
    {
        reportDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public int? id { get; set; } = null;
    public string workReportType { get; set; } = "YW";
    public string businessType { get; set; } = "YW";
    public string reportDate { get; set; }
    public int? userId { get; set; }
    public string? problemFeedback { get; set; }
    public string? projectProgress { get; set; }
    public string projectId { get; set; }
    public int? projectCompletionRate { get; set; } = 100;
    public int? workingOurs { get; set; } = 8;
    public string? output { get; set; }
    public string? archives { get; set; }
    public string? notArchiveReason { get; set; }
    public int? deptId { get; set; }
    public string? supplier { get; set; }
    public string? supplierContact { get; set; }
    public string? workPlan { get; set; }
    public string? remark { get; set; }
    public int? delFlag { get; set; }
    public string? createBy { get; set; }
    public string? createTime { get; set; }
    public string? updateBy { get; set; }
    public string? updateTime { get; set; }


}
