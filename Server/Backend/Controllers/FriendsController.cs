using Backend.Models;
using Backend.Models.Invitation;
using Backend.Services.Friends;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : Controller
    {
        private readonly IFriendsService _friendsService;

        public FriendsController(IFriendsService friendsService)
        {
            this._friendsService = friendsService;
        }
        [Authorize]
        [HttpGet]
        [Route("getUserFriends")]
        public async Task<IActionResult> GetUserFriends([FromQuery] string userId)
        {
            var result = await _friendsService.GetUserFriends(userId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [Authorize]
        [HttpGet]
        [Route("getUserFriendInvitations")]
        public async Task<IActionResult> GetUserFriendInvitations([FromQuery] string userId)
        {
            var result = await _friendsService.GetUserFriendInvitations(userId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        } 
        //[Authorize]
        //[HttpPost]
        //[Route("addFriends")]
        //public async Task<IActionResult> AddFriends([FromBody] AddFriends addFriends)
        //{
        //    var result = await _friendsService.AddFriends(addFriends);
        //    if (result.Data != null)
        //    {
        //        return Ok(result.Data);
        //    }
        //    return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        //}

        [Authorize]
        [HttpPost]
        [Route("addFriendInvitation")]
        public async Task<IActionResult> AddFriendInvitation([FromBody] AddFriendInvitations addFriendInvitation)
        {
            var result = await _friendsService.AddFriendsInvitation(addFriendInvitation);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpPatch]
        [Route("approveInvitation")]
        public async Task<IActionResult> ApproveInvitation([FromQuery] string invitationId)
        {
            var result = await _friendsService.ApproveInvitation(invitationId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpPatch]
        [Route("rejectInvitation")]
        public IActionResult RejectInvitation([FromQuery] string invitationId)
        {
            var result = _friendsService.RejectInvitation(invitationId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpGet]
        [Route("getSearchedUsers")]
        public async Task<IActionResult> GetSearchedUsers([FromQuery] string toSearch, [FromQuery] string currentUserId)
        {
            var result = await _friendsService.GetSearchedUsers(currentUserId, toSearch);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

    }
}
