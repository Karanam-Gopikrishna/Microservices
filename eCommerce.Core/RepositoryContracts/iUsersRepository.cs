using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts
{
    /// <summary>
    /// Defines the iUsersRepository interface which acts as a contract for the UsersRepository
    /// </summary>
    public interface iUsersRepository
    {
        Task<ApplicationUser> AddUser(ApplicationUser registerRequest);


        /// <summary>
        /// Method to get existing user by email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
        
    }
}