using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using eCommerce.Core.Entities;
using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContracts
{
    public interface iUserService
    {
        /// <summary>
        /// Method to handle the user login use case and 
        /// returns the 'AuthenticationResponse' object that 
        // contains the status of the login
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
       Task<AuthenticationResponse?> Login(LoginRequest loginRequest);


       /// <summary>
       /// Method to handle the user login use case and 
       /// returns the 'AuthenticationResponse' object that 
       /// contains the status of the login
       /// </summary>
       /// <param name="registerRequest"></param>
       /// <returns></returns>

       Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
    }
}