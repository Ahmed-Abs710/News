using Microsoft.EntityFrameworkCore;
using News.Data;
using News.DTOs;
using News.Models;

namespace News.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public async Task<UserDto>AddAsync(CreateUserDto userDto)
        {
            var user = new User
            {
                Email= userDto.Email,
                IsAdmin = userDto.IsAdmin,
                Password = userDto.Password,
                Username = userDto.UserName
            };
            await Context.users.AddAsync(user);
            await Context.SaveChangesAsync();
            return new UserDto
            {
                Email = user.Email,
                Id = user.Id,
                Username = user.Username
            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var res = await Context.users.FindAsync(id);
            if (res != null)
            {
                Context.users.Remove(res);
                await Context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Context.users.ToListAsync();
        }

        public async Task<UserDto> GetUsersByIdAsync(int id)
        {
           var user = await Context.users.FindAsync(id);
            if (user != null)
            { return new UserDto { Email = user.Email
                , Id = user.Id , Username = user.Username};
            }
            return null;
        }

        public async Task<UserDto> UpdateAsync(UpdateUserDto userDto)
        {
            var result = await Context.users.FindAsync(userDto.Id);
            if (result != null)
            {
                result.Username = userDto.UserName;
                result.Password = userDto.Password;
                result.Email = userDto.Email;
                Context.users.Update(result);
                await Context.SaveChangesAsync();
                return new UserDto
                {
                    Email = result.Email,
                    Id = result.Id,
                    Username = result.Username
                };
            }
            return null;
        }

       
    }
}
