using News.DTOs;
using News.Models;

namespace News.Services
{
    public interface ILoginService
    {
        string GenerateToken(User user);

        Task<string> LoginAsync(LoginDto dto);

    }
}
