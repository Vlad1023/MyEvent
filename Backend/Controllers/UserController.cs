using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        [Route("getUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _userService.GetUsers();
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpPost]
        [Route("getEventParticipants")]
        public async Task<IActionResult> GetEventParticipants([FromBody]string[] userIds)
        {
            var result = await _userService.GetUsersEventsParticipants(userIds);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new HttpResponse {} JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpGet]
        [Route("getUserByUserName")]
        public async Task<IActionResult> GetUserByUserName([FromQuery] string username)
        {
            var result = await _userService.GetUserByUsername(username);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpGet]
        [Route("getUsersByString")]
        public async Task<IActionResult> GetUsersByString([FromQuery] string username)
        {
            var result = await _userService.GetUsersBySring(username);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpPut]
        [Authorize]
        [Route("update")]
        public async Task<IActionResult> Update([FromQuery] string id,[FromBody]UpdateUser model)
        {
            var result = await _userService.UpdateUser(id, model);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _userService.LoginUser(model);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message)  { StatusCode = result.Error.Code };
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await _userService.AddUser(model);
            
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

    }
}
