using News.DTOs;
using News.Models;

namespace News.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<UserDto> GetUsersByIdAsync(int id);

        Task<UserDto> AddAsync(CreateUserDto userDto);

        Task<UserDto> UpdateAsync(UpdateUserDto userDto);

        Task<bool> DeleteAsync(int id);
    }
}
