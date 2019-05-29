using ProyectoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial1.DAL
{
    class Contexto : DbContext
    {

        public DbSet<Productos> Productos { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}    