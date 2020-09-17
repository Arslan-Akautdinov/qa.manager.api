using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qa.manager.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace qa.manager.host.Controllers
{
    public class MetricsController
    {

        private readonly ILogger<ReportsController> _logger;
        private readonly ApplicationContext _context;

        public MetricsController(ILogger<ReportsController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("metrics/{reportId}")]
        public ICollection<Metric> GetMetrics(int reportId) => _context
            .Metrics.Where(x => x.ReportId == reportId).ToList();
    }
}
