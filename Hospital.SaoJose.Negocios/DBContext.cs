using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.SaoJose.Negocios
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        {
        }

        public DbSet<ProfissionalSaude> ProfissionalSaude { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Laudo> Laudos { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
    }
}
