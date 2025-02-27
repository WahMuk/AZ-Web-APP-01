using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AZ_Web_APP_01.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configration;

        public IndexModel(ILogger<IndexModel> logger,IConfiguration configration)
        {
            _logger = logger;
            this._configration = configration;
        }

        public void OnGet()
        {
            ViewData["Greeting"] = _configration["Greeting"];
        }
    }
}
