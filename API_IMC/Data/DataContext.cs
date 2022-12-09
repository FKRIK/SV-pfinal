using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMC_aplication.Models;
using Microsoft.EntityFrameworkCore;

namespace IMC_aplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imc> Imcs { get; set; }
    }
}