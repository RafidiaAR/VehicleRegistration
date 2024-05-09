using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VehicleRegistrationFE.Models;

namespace VehicleRegistrationFE.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Create()
        {
            var viewModel = new CreateDocumentViewModel
            {
                LokasiPenyimpananList = GetLokasiPenyimpananList()
            };
            return View(viewModel);
        }

        private List<SelectListItem> GetLokasiPenyimpananList()
        {
            var locations = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Location 1" },
                new SelectListItem { Value = "2", Text = "Location 2" },
            };
            return locations;
        }
    }
}
