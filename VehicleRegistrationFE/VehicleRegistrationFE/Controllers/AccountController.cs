using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using VehicleRegistrationFE.Models;
using VehicleRegistrationFE.Models.Request;
using VehicleRegistrationFE.Models.Response;
using Microsoft.AspNetCore.Http;

namespace VehicleRegistrationFE.Controllers
{
    public class AccountController : Controller
    {
        private readonly string _baseUrl;

        public AccountController(IOptions<BackendAPIConfig> backendApiConfig)
        {
            _baseUrl = backendApiConfig.Value.BaseUrl;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            string username = HttpContext.Session.GetString("Username");
            if (!string.IsNullOrEmpty(username)) 
            {
                return RedirectToAction("Create", "Document");
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var request = new UserLoginRequest
            {
                Username = model.UserName,
                Password = model.Password,
            };
            string url = $"{_baseUrl}/User/Login";
            HttpClientHandler clientHandler = new HttpClientHandler();
            using (HttpClient httpClient = new HttpClient(clientHandler))
            {
                string strData = JsonConvert.SerializeObject(request);

                StringContent contentData = new StringContent(strData, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, contentData);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<UserLoginResponse>(content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    HttpContext.Session.SetString("Username", result.Data.Username);
                    return RedirectToAction("Create", "Document");
                }
                else
                {
                    ViewBag.Errors = result.Message;
                    return View(model);
                }
            }
        }
    }
}
