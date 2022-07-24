using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nkwo.Domain.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkwo.Domain.Context
{
    public class NkwoIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public NkwoIdentityDbContext(DbContextOptions<NkwoIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfiguration(new UserRoleService());
        }
    }
}
