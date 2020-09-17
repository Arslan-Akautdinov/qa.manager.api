using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using qa.manager.models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;

namespace qa.manager.host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly ILogger<ReportsController> _logger;
        private readonly ApplicationContext _context;

        public ReportsController(ILogger<ReportsController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public Report AddReport(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();
            return _context.Reports.FirstOrDefault(x =>
                x.ProjectId == report.ProjectId &&
                x.ScopeId == report.ScopeId &&
                x.StandId == report.StandId);
        }

        [HttpGet]
        [Route("{reportId}")]
        public Report GetReport(int reportId) => _context.Reports.FirstOrDefault(x => x.Id == reportId);

        [HttpGet]
        public ICollection<Report> GetReports() => _context.Reports.ToList();

        [HttpPut]
        public async Task<string> AddReport(IFormFile reportFile)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", reportFile.FileName);
            using (var stream = System.IO.File.Create(filePath))
            {
                await reportFile.CopyToAsync(stream);
            }
            return reportFile.FileName;
        }
    }
}
