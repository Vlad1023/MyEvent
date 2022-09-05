using AutoMapper;
using Backend.Models;
using Backend.Models.Review;
using Backend.Repositories;
using Backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class ReviewService : IReviewService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<Result<ReviewResponce>> AddReview(AddReview newReview)
        {
            if (_unitOfWork.Reviews.GetUserEventReviews(newReview.EventId, newReview.AuthorId).Any())
            {
                return Result<ReviewResponce>.GetError(500, "You've already reviewed it");
            }
            var result = await _unitOfWork.Reviews.Add(_mapper.Map<ReviewsDB>(newReview));
            if(result == null)
                return Result<ReviewResponce>.GetError(500, "Iternal server error while adding review");
            var eventReviews = _unitOfWork.Reviews.GetEventReviews(newReview.EventId);
            var resultRank = (newReview.Rate + eventReviews.Select(el => el.Rate).Sum()) / (eventReviews.Count() + 1);
            _unitOfWork.Events.AddRateToEvent(newReview.EventId, resultRank);
            _unitOfWork.Complete();
            return Result<ReviewResponce>.GetSuccess(_mapper.Map<ReviewResponce>(result));
        }
    }
}
