  
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsejeriaEPICS.Data{

    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ConsejeriaEPICS.Models.Categoria> Categorias { get; set; }
        public DbSet<ConsejeriaEPICS.Models.Requerimiento> Requerimientos { get; set; }
        public DbSet<ConsejeriaEPICS.Models.Usuario> Usuarios { get; set; }
    }
}