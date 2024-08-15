using News.DTOs;
using News.Models;

namespace News.Repositories
{
    public interface ILoginRepository
    {
        Task<User>CheckUserInfoAsync(LoginDto user);
    }
}
