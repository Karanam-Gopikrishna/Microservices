using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace eCommerce.Core.DTO
{
    /// <summary>
    /// Defines the Authenticationresponse class which acts as a model for the authentication response DTO
    /// </summary>
    public record AuthenticationResponse(
        Guid UserId,
        string? UserName,
        string? Email,
        string? Gender, 
        string? Token, 
        bool Success, 
        string? ErrorMessage);
    
}