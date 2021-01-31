using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.User
{
    public class Register
    {
        public class Command : IRequest<User>
        {
            public string DisplayName { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Handler : IRequestHandler<Command, User>
        {
            private readonly DataContext context;
            private readonly IJwtGenerator jwtGenerator;
            private readonly UserManager<AppUser> userManager;
            public Handler(DataContext context, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator)
            {
                this.userManager = userManager;
                this.jwtGenerator = jwtGenerator;
                this.context = context;
            }
            public async Task<User> Handle(Command request, CancellationToken cancellationToken)
            {
                if(await this.context.Users.Where(x => x.Email == request.Email).AnyAsync())
                    throw new Exception("Postoji email vec");
                if(await this.context.Users.Where(x => x.UserName == request.Username).AnyAsync())
                    throw new Exception("Postoji username vec");
                var user = new AppUser
                {
                    DisplayName = request.DisplayName,
                    Email = request.Email,
                    UserName = request.Username
                };
                var result = await userManager.CreateAsync(user, request.Password);
                Console.WriteLine("Line succeeded");
                if (result.Succeeded)
                {
                    return new User
                    {
                        DisplayName = request.DisplayName,
                        Token = jwtGenerator.CreateToken(user),
                        Username = user.UserName
                    };
                }
                Console.WriteLine(request.DisplayName);
                Console.WriteLine(request.Email);
                Console.WriteLine(request.Username);
                Console.WriteLine(request.Password);
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine(user.Email);
                Console.WriteLine(user.DisplayName);
                Console.WriteLine(user.UserName);

                throw new Exception("Problem creating user");
            }
        }
    }
}