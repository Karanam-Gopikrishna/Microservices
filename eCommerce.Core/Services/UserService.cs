using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using eCommerce.Core.Entities;
using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using eCommerce.Core.RepositoryContracts;

namespace eCommerce.Core.ServiceContracts
{
    
   internal class UserService : iUserService
   {
    private readonly iUsersRepository _usersRepository;

    public UserService(iUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public  async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
    {
        ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
     
        if (user == null)
        {
           return null;
        }
        return new AuthenticationResponse
        (user.UserId, user.UserName, user.Email, user.Gender, "token",Success: true, ErrorMessage: null);
    }
    public async  Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
    {
        ApplicationUser user = new ApplicationUser
        {
            UserName = registerRequest.UserName,
            Email = registerRequest.Email,
            Password = registerRequest.Password,
            Gender = registerRequest.Gender.ToString()
        };

        ApplicationUser? registerUser = await _usersRepository.AddUser(user);
        if (registerUser == null)
        {
            return null;
        }
        return new AuthenticationResponse
        (registerUser.UserId,registerUser.UserName,registerUser.Email,registerUser.Gender,"token",Success: true,ErrorMessage: null);
    }

   }
}