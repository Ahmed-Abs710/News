using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.DTOs;
using News.Models;
using News.Services;

namespace News_Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserService service)
        {
            Service = service;
        }

        public IUserService Service { get; }


        [HttpGet("GetAll")]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await Service.GetAllAsync();
        }

        [HttpGet("GetUsersById")]
        public async Task<UserDto> GetUsersById(int id)
        {
            return await Service.GetUsersByIdAsync(id);
        }

      
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserDto userDto)
        {
            var res = await Service.AddAsync(userDto);
            return Ok(res);
        }

        [HttpPut("Update")]
        public async Task<UserDto> Update(UpdateUserDto userDto)
        {
            return await Service.UpdateAsync(userDto);
        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete(int id)
        {
            return await Service.DeleteAsync(id);
        }

        //[HttpPost("SendEmailToUser")]
        //public async Task SendEmailToUser(string ToEmail, string Subject, string Message)
        //{
        //     await Service.SendEmailToUserAsync(ToEmail, Subject, Message);
        //}
    }
}
