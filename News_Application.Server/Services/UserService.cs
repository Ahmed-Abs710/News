using MediatR;
using Microsoft.EntityFrameworkCore;
using News.CQRS.Commands.Request;
using News.CQRS.Queries.Request;
using News.Data;
using News.DTOs;
using News.Models;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;

namespace News.Services
{
    public class UserService : IUserService
    {
        public UserService(IMediator mediator, IConfiguration configuration)
        {
           
            Mediator = mediator;
            Configuration = configuration;
          
        }

        public IMediator Mediator { get; }
        public IConfiguration Configuration { get; }
      

        public async Task<UserDto> AddAsync(CreateUserDto userDto)
        {
          

            return await Mediator.Send(new CreateUserCommand(userDto));
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await Mediator.Send(new DeleteUserCommand(id));
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Mediator.Send(new GetAllUserQuery());
        }

        public async Task<UserDto> GetUsersByIdAsync(int id)
        {
            return await Mediator.Send(new GetUserByIdQuery(id));
        }

        public async Task SendEmailToUserAsync(string ToEmail, string Subject, string Message)
        {
            var mailSettings = Configuration.GetSection("EmailSettings");
            using (var client = new SmtpClient(mailSettings["SmtpServer"], int.Parse(mailSettings["SmtpPort"])))
            {
                client.Credentials = new NetworkCredential(mailSettings["SmtpUsername"], mailSettings["SmtpPassword"]);
                client.EnableSsl = true;
                var mailmessage = new MailMessage
                {
                    From = new MailAddress(mailSettings["FromEmail"]),
                    Subject = Subject,
                    Body = Message,
                    IsBodyHtml = true
                };
                mailmessage.To.Add(ToEmail);
               await client.SendMailAsync(mailmessage);
            }
        }

        public async Task<UserDto> UpdateAsync(UpdateUserDto userDto)
        {
            return await Mediator.Send(new UpdateUserCommand(userDto));
        }
    }
}
