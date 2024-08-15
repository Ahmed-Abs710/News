using Microsoft.IdentityModel.Tokens;
using News.DTOs;
using News.Models;
using News.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace News.Services
{
    public class LoginService : ILoginService
    {
        public LoginService(IConfiguration configuration, ILoginRepository login)
        {
            Configuration = configuration;
            Login1 = login;
        }



        public IConfiguration Configuration { get; }
        public ILoginRepository Login1 { get; }

        public string GenerateToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSettings:SecretKey"]));

            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var Claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim("UserId",user.Id.ToString()),
                new Claim("IsAdmin",user.IsAdmin.ToString())
            };

            var tokenOptions = new JwtSecurityToken
            (
                  issuer: Configuration["JwtSettings:Issuer"],
                 audience: Configuration["JwtSettings:Audience"],
                 claims: Claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(Configuration["JwtSettings:ExpiryMinutes"])),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
           // return null;
        }

       

        public async Task<string> LoginAsync(LoginDto dto)
        {
            var res = await Login1.CheckUserInfoAsync(dto);
            if (res != null)
            {
               return GenerateToken(res);
            }
            else
            {
                return "Invalid Username Or Password";
            }
        }
    }
}
