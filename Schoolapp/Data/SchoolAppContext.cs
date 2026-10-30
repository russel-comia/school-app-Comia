using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Schoolapp.Models;

namespace SchoolApp.Data
{
    public class SchoolAppContext : DbContext
    {
        public SchoolAppContext (DbContextOptions<SchoolAppContext> options)
            : base(options)
        {
        }

        public DbSet<Schoolapp.Models.Student> Student { get; set; } = default!;
    }
}
