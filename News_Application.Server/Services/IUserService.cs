using News.DTOs;
using News.Models;

namespace News.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<UserDto> GetUsersByIdAsync(int id);

        Task<UserDto> AddAsync(CreateUserDto userDto);

        Task<UserDto> UpdateAsync(UpdateUserDto userDto);

        Task<bool> DeleteAsync(int id);

        Task SendEmailToUserAsync(string ToEmail ,string Subject ,string Message);
    }
}
