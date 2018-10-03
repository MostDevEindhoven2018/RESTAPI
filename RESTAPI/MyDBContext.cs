using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTAPI;

namespace RESTAPI
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()  : base()
        {

        }

        public MyDBContext(DbContextOptions options) :base(options)
        {

        }
        
        public DbSet<Movie> Movies { get; set; }
    }
}
