using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SingleResponsibilityDesignPrinciplesSample.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityDesignPrinciplesSample
{
    public class Db_Connection : DbContext
    {
        public Db_Connection() : base()
        {

        }

        public DbSet<Personel> Personels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SingeResponsibilityPrinciple; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
