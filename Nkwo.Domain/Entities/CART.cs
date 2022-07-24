using Nkwo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkwo.Domain.Entities
{
    public class CART
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
