using MediatR;
using News.DTOs;
using News.Models;

namespace News.CQRS.Commands.Request
{
  public record CreateArticleCommand(AddArticelDto Dto) : IRequest<AddArticelDto>;
  
}
