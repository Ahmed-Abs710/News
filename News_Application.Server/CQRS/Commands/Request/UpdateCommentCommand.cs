using MediatR;
using News.DTOs;
using News.Models;

namespace News.CQRS.Commands.Request
{
    public record UpdateCommentCommand(UpdateCommentDto Dto) : IRequest<Comment>;
  
}
