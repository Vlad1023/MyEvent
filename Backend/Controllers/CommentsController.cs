using Backend.Models.Comments;
using Backend.Services.Comments;
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
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            this._commentService = commentService;
        }

        [HttpPost]
        [Route("addComment")]
        [Authorize]
        public async Task<IActionResult> AddComment([FromBody] AddComment newComment)
        {
            var result = await _commentService.AddComment(newComment);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpGet]
        [Route("getEventComments")]
        [Authorize]
        public async Task<IActionResult> GetEventComments([FromQuery] string eventId)
        {
            var result = await _commentService.GetEventComments(eventId);
            if (result != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
    }
}
