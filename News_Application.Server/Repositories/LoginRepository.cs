using Microsoft.EntityFrameworkCore;
using News.Data;
using News.DTOs;
using News.Models;

namespace News.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public LoginRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public async Task<User> CheckUserInfoAsync(LoginDto user)
        {
            var res = await Context.users.Where(x => x.Username == user.UserName && x.Password == user.Password).FirstOrDefaultAsync();
            if (res != null)
            {
                return res;
            }
            return null;
        } 
    }
}
