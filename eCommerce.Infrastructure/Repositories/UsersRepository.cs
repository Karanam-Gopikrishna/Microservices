using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.Entities;
using eCommerce.Core.DTO;

namespace eCommerce.Infrastructure.Repositories
{
    internal class UsersRepository : iUsersRepository
    {
        public async Task<ApplicationUser> AddUser(ApplicationUser user)
        {
            //Generate a new user id
            user.UserId = Guid.NewGuid();
            return user;
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            return new ApplicationUser
            {
                UserId = Guid.NewGuid(),
                Email = email,
                Password = password,
                UserName = "Gopikrishna Karanam",
                Gender = GenderOptions.Male.ToString()
            };
        }
    }
}