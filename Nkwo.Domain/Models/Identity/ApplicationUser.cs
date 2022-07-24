using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkwo.Domain.Models.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public Guid? CountryCallingCode { get; set; }
        public string? RefreshToken { get; set; }
    }
}
