using dotNetStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetStore.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public DbSet<dotNetStore.Models.User> Users { get; set; } = default!;
        public DbSet<dotNetStore.Models.Contact> Contacts { get; set; } = default!;
    }
}
