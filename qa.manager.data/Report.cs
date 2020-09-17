using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qa.manager.models
{
    public class Report
    {
        public Report()
        {
            ReportStatistics = new List<Metric>();
        }

        [Key]
        public int Id { get; set; }
        public int StandId { get; set; }
        public int ScopeId { get; set; }
        public int ProjectId { get; set; }
        public string SourcePath { get; set; }
        public List<Metric> ReportStatistics { get; set; }
    }
}
