using MediatR;
using News.DTOs;
using News.Models;

namespace News.CQRS.Commands.Request
{
    public record CreateCommentCommand(CommentDto Dto) :IRequest<Comment>;
   
}
