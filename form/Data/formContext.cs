using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using form.Models;

namespace form.Data
{
    public class formContext : DbContext
    {
        public formContext (DbContextOptions<formContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<form.Models.Employee> Employee { get; set; }
    }
}
