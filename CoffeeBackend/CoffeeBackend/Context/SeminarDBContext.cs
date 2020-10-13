using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBackend.Context
{
    public class SeminarDBContext : DbContext
    {
        //List entities
        public DbSet<Seminar> seminars { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
   
        public SeminarDBContext(DbContextOptions<SeminarDBContext> options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
