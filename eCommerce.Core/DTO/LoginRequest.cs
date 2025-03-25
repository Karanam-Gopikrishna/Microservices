using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace eCommerce.Core.DTO
{
    /// <summary>
    /// Defines the LoginRequest class which acts as a model for the login request DTO
    /// </summary>
    public record LoginRequest(
        string? Email, 
        string? Password
        );

}