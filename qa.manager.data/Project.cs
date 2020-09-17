using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qa.manager.models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Report> Reports { get; set; }
    }
}
