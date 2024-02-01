using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
namespace ConsoleToDB.Data
{
    public class DataContext : DbContext
    {
        public readonly object Categories;
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        public virtual DbSet<Display> Display { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SC4BHGR\\MSSQLSERVER01;Initial Catalog=StudentReport;Integrated Security=True;TrustServerCertificate=True;");
    }
}