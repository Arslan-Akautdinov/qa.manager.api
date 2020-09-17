using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qa.manager.models
{
    public class Stand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Report> Reports { get; set; }
    }
}
