using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace sample_efcore
{
    public class TestContext : DbContext
    {
        public DbSet<tempView> tempViews { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=192.168.110.32;user=root;password=123456;port=3307;database=temp";
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}