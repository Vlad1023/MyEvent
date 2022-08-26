using AutoMapper;
using Backend.Models;
using Backend.Models.Comments;
using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Comments
{
    public class CommentService : ICommentService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        readonly IUserService _userService;
        public CommentService(IUnitOfWork unitOfWork, IMapper mapper, IUserService userService)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._userService = userService;
        }
        public async Task<Result<CommentResponce>> AddComment(AddComment newComment)
        {
            var result = await _unitOfWork.CommentRepository.Add(_mapper.Map<CommentsDB>(newComment));
            return Result<CommentResponce>.GetSuccess(_mapper.Map<CommentResponce>(result));
        }

        public async Task<Result<IEnumerable<CommentResponce>>> GetEventComments(string eventId)
        {
            var result = _unitOfWork.CommentRepository.GetEventComments(eventId);
            var mappedComments = _mapper.Map<IEnumerable<CommentResponce>>(result);
            for (int i = 0; i < mappedComments.Count(); i++)
            {
                var foundUser = await _userService.GetUserById(result.ElementAt(i).AuthorId);
                mappedComments.ElementAt(i).AuthorName = foundUser.Data.Login;
            }
            return Result<IEnumerable<CommentResponce>>.GetSuccess(mappedComments);
        }
    }
}
