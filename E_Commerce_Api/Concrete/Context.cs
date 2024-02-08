using System;
using E_Commerce_Api.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Api.Concrete
{
	public class Context:DbContext
	{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }


        public Context(DbContextOptions options) : base(options) {

            
        }
        

        public DbSet<User> Users { get; set; }

        public DbSet<Urun> Uruns { get; set; }



    }
}

