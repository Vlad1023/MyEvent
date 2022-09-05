using Backend.Models;
using Backend.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IReviewService
    {
        Task<Result<ReviewResponce>> AddReview(AddReview newReview);
    }
}
