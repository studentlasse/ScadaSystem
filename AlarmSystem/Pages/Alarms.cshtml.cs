using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlarmSystem.Pages
{
    public class AlarmsModel : PageModel
    {
        private readonly ILogger<AlarmsModel> _logger;

        public AlarmsModel(ILogger<AlarmsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
