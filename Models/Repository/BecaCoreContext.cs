using CoreApiEfCodeFirst.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Repository.Context
{
    public class BecaCoreContext : DbContext {



        public BecaCoreContext(DbContextOptions opt) : base(opt){
        
        }

        public BecaCoreContext() {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("DefaultConnString") ?? 
                "Data Source=(localdb)\\v11.0;Initial Catalog=beca_net_core;Integrated Security=True");
        }


        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}
