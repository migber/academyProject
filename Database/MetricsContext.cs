using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;

namespace Database
{
   public class MetricsContext : DbContext
    {
        public DbSet<ComputerDetail> ComputerDetails { get; set; }
        public DbSet<UsageData> UsageDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // kelias iki duomenu bazes
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "metrics.db" }; 
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }


    }
}
