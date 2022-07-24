using Microsoft.EntityFrameworkCore;
using Nkwo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkwo.Domain.Context
{
    public class NkwoDbContext: DbContext
    {
        public NkwoDbContext(DbContextOptions<NkwoDbContext> options) : base(options)
        {

        }
        public DbSet<CART> Carts { get; set; }
    }
}
