using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace eCommerce.Core.DTO
{
    /// <summary>
    /// Defines the RegisterRequest class which acts as a model for the register request DTO
    /// </summary>
    public record RegisterRequest(
        string? UserName,
        string? Email, 
        string? Password, 
        GenderOptions gender
        );

}