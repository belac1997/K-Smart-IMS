using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProjectTest.Pages
{
    public class CurrentInventoryModel : PageModel
    {
        private readonly ILogger<CurrentInventoryModel> _logger;

        public CurrentInventoryModel(ILogger<CurrentInventoryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}