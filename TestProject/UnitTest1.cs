using FluentAssertions;
using MediatR;
using Microsoft.Extensions.Configuration;
using Moq;
using News.CQRS.Commands.Request;
using News.CQRS.Queries.Request;
using News.DTOs;
using News.Repositories;
using News.Services;
using Xunit;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IUserRepository> Iuser;
        private readonly Mock<IMediator> med;
        private readonly IConfiguration conf;
        private readonly UserService service;
        public UnitTest1()
        {
            Iuser = new Mock<IUserRepository>();
            med = new Mock<IMediator>();
            conf = new ConfigurationBuilder().AddInMemoryCollection().Build();
            service = new UserService(med.Object,conf);
        }

        [Fact]
        public async void AddUser()
        {
            var user = new CreateUserDto
            {
                Email = "Test@Email.com",
                IsAdmin =true,
                Password="123",
                UserName="TestUser"
            };

            var ex = new UserDto
            {
               
                Email = "Test@Email.com",
                Username = "TestUser"
            };
            med.Setup(s => s.Send(It.IsAny<CreateUserCommand>(),It.IsAny<CancellationToken>())).ReturnsAsync(ex);

            var res =await service.AddAsync(user);

            Xunit.Assert.NotNull(res);
            Xunit.Assert.Equal(ex.Email, res.Email);
            Xunit.Assert.Equal(ex.Username, res.Username);
        }

       
    }
}