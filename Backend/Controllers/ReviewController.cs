using Backend.Models.Review;
using Backend.Services;
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
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this._reviewService = reviewService;
        }
        [HttpPost]
        [Route("addReview")]
        [Authorize]
        public async Task<IActionResult> AddReview([FromBody] AddReview newReview)
        {
            var result = await _reviewService.AddReview(newReview);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
    }
}
