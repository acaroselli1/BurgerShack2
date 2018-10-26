using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurgerShack.Entities;

namespace BurgerShack.Web.Models
{
    public class BurgerShackWebContext : DbContext
    {
        public BurgerShackWebContext (DbContextOptions<BurgerShackWebContext> options)
            : base(options)
        {
        }

        public DbSet<BurgerShack.Entities.Burger> Burger { get; set; }
    }
}
