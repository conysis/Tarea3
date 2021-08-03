using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
