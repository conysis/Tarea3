using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClient.Pages
{
    public class ListarModel : PageModel
    {
        private readonly ILogger<ListarModel> _logger;

        public ListarModel(ILogger<ListarModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
