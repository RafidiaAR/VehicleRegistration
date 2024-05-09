using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationBE.Helper;
using VehicleRegistrationBE.Repositories;

namespace VehicleRegistrationBE.Controllers
{
    [Route("storageLocations")]
    public class StorageLocationController : Controller
    {
        //repository
        private readonly StorageLocationRepository _repositoryStorageLocation;

        public StorageLocationController(
            //repository
            StorageLocationRepository repositoryStorageLocation
            )
        {
            //repository
            _repositoryStorageLocation = repositoryStorageLocation;
        }

        /* get list location
        */
        [HttpGet("")]
        public IActionResult GetAll()
        {
            var data = _repositoryStorageLocation.GetAll();

            return Ok(ResponseBuilder.SuccessResponse("success get list location", data));
        }
    }
}
