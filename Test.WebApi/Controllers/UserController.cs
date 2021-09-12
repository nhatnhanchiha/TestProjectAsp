using Microsoft.AspNetCore.Mvc;
using Test.BusinessTier.Responses.Common;
using Test.WebApi.Entity;
using Test.WebApi.Models;
using Test.WebApi.Services;

namespace Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return Ok(MyResponse<object>.FailWithMessage("Wrong username or password"));

            return Ok(response);
        }

        [HttpGet]
        [CasbinAuthorize]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}