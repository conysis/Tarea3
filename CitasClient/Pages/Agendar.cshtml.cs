using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClient.Pages
{
    public class AgendarModel : PageModel
    {
        private readonly ILogger<AgendarModel> _logger;

        public AgendarModel(ILogger<AgendarModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
