using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using System.Text;
using VehicleRegistrationFE.Models;
using VehicleRegistrationFE.Models.Request;
using VehicleRegistrationFE.Models.Response;

namespace VehicleRegistrationFE.Controllers
{
    public class DocumentController : Controller
    {
        private readonly string _baseUrl;

        public DocumentController(IOptions<BackendAPIConfig> backendApiConfig)
        {
            _baseUrl = backendApiConfig.Value.BaseUrl;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<SelectListItem> listLokasi = await GetLokasiPenyimpananList();

            var viewModel = new CreateDocumentViewModel
            {
                LokasiPenyimpananList = listLokasi
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDocumentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.LokasiPenyimpananList = await GetLokasiPenyimpananList();
                return View(model);
            }

            var request = new CreateDocumentRequest
            {
                AgreementNumber = model.AgreementNumber,
                BPKBNo = model.NoBPKB,
                BranchId = model.BranchID,
                BPKBDate = model.TanggalBPKB,
                FakturNo = model.NoFaktur,
                FakturDate = model.TanggalFaktur,
                LocationId = model.LokasiPenyimpanan,
                PoliceNo = model.NoPolisi,
                BPKBDateIn = model.TanggalBPKBIn,
                CreatedBy = HttpContext.Session.GetString("Username")
        };
            string url = $"{_baseUrl}/document";
            HttpClientHandler clientHandler = new HttpClientHandler();
            using (HttpClient httpClient = new HttpClient(clientHandler))
            {
                string strData = JsonConvert.SerializeObject(request);

                StringContent contentData = new StringContent(strData, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, contentData);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CreateDocumentResponse>(content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return RedirectToAction("Create", "Document");
                }
                else
                {
                    ViewBag.Errors = result.Message;
                    return View(model);
                }
            }
        }
        private async Task<List<SelectListItem>> GetLokasiPenyimpananList()
        {
            var result = new StorageLocationResponse();
            var locations = new List<SelectListItem>();

            string url = $"{_baseUrl}/storageLocations";
            HttpClientHandler clientHandler = new HttpClientHandler();
            using (HttpClient httpClient = new HttpClient(clientHandler))
            {
                var response = await httpClient.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<StorageLocationResponse>(content);
                }
                else
                {
                    throw new Exception($"Failed to Login");
                }
            }

            if (result.data.Count != 0) 
            {
                foreach (var item in result.data) 
                {
                    locations.Add(new SelectListItem
                    {
                        Value = item.LocationId,
                        Text = item.LocationName
                    });
                }
            }
            return locations;
        }
    }
}
