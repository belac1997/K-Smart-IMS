using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProjectTest.Pages
{
    public class InventoryEditModel : PageModel
    {
        private readonly ILogger<InventoryEditModel> _logger;

        public InventoryEditModel(ILogger<InventoryEditModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}