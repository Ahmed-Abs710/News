using MediatR;
using News.DTOs;
using News.Models;

namespace News.CQRS.Commands.Request
{
    public record UpdateArticleCommand(UpdateArticelDto Dto) : IRequest<Article>;
  
}
