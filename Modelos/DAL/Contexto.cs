using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Modelos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Estacionamento")
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Entrada> Estacionados { get; set; }
    }
}




   
    

        

       