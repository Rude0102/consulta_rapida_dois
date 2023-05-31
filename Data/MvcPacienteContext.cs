using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using consulta_rapida.Models;

    public class MvcPacienteContext : DbContext
    {
        public MvcPacienteContext (DbContextOptions<MvcPacienteContext> options)
            : base(options)
        {
        }

        public DbSet<consulta_rapida.Models.Paciente> Paciente { get; set; }
    }
