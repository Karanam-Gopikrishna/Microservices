using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")] //api/Authentication
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly iUserService _userService;

        public AuthenticationController(iUserService userService)
        {
            _userService = userService;
        }

        [Route("register")] //api/Authentication/register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            //check for invalid registration request
            if(registerRequest == null)
            {
                return BadRequest("Invalid registration request");
            }

            // call the user service to handle the registration
            AuthenticationResponse? authenticationResponse = await _userService.Register(registerRequest);

            if(authenticationResponse == null || authenticationResponse.Success == false)
            {
                return BadRequest(authenticationResponse);
            }
            return Ok(authenticationResponse);
        }

        [Route("login")] //api/Authentication/login
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            //check for invalid login request
            if(loginRequest == null)
            {
                return BadRequest("Invalid login details");
            }
            // call the user service to handle the login
            AuthenticationResponse? authenticationResponse = await _userService.Login(loginRequest);
            if(authenticationResponse == null || authenticationResponse.Success == false)
            {
                return Unauthorized(authenticationResponse);
            }
            return Ok(authenticationResponse);
            
        }
    }
}