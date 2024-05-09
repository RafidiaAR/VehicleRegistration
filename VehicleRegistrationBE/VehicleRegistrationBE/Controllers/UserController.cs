using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationBE.Helper;
using VehicleRegistrationBE.Models.Request;
using VehicleRegistrationBE.Models.Response;
using VehicleRegistrationBE.Repositories;

namespace VehicleRegistrationBE.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        //repository
        private readonly UserRepository _repositoryUser;

        public UserController(
            //repository
            UserRepository repositoryUser
            )
        {
            //repository
            _repositoryUser = repositoryUser;
        }

        /* login user
        * @param object UserLoginRequest request
        */
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserLoginRequest request)
        {
            var data = _repositoryUser.FindByUsernameAndPassword(request.Username, request.Password);

            if (data == null) 
            {
                return Unauthorized(ResponseBuilder.ErrorResponse(401, "Please check your username or password", null));
            }

            var result = new UserLoginResponse
            {
                Username = data.Username,
                IsActive = data.IsActive,
            };

            return Ok(ResponseBuilder.SuccessResponse("success login", result));
        }
    }
}
