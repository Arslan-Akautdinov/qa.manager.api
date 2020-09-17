using System;
using System.ComponentModel.DataAnnotations;

namespace qa.manager.models
{
    public class Metric
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ReportId { get; set; }
        public int Count { get; set; }
        public int Passed { get; set; }
        public int Failed { get; set; }
        public int Broken { get; set; }
        public int Skipped { get; set; }
        public int Duration { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public Report report { get; set; }
    }
}
