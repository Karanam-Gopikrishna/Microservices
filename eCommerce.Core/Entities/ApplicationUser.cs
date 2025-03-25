using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace eCommerce.Core.Entities
{
    /// <summary>
    /// Defines the ApplicationUser class which acts as a model for the user entity model class to store 
    // user information in data store
    /// </summary>
    public class ApplicationUser
    {
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}