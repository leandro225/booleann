using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public  class Entrada
    {


        public Boolean estaEstacionado { get; set; }

        public int entradaId { get; set; }

        public string DataEstacionar { get; set; }

        public int clienteId { get; set; }

        public string placaCarro { get; set; }

        public string modeloCarro { get; set; }

        public string corCarro { get; set; }

        public  Carro carro { get; set; }

        public double Total { get; set; }

        /*
         public Boolean EstaEstacionado()
        {
            return estaEstacionado;
        }

        public void setEstaEstacionado(Boolean estaEstacionado)
        {
            this.estaEstacionado = estaEstacionado;
        }*/


    }
}
