using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc5.Models;

namespace SalesWebMvc5.Data
{
    public class SalesWebMvc5Context : DbContext
    {
        public SalesWebMvc5Context (DbContextOptions<SalesWebMvc5Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc5.Models.Department> Department { get; set; }
    }
}
