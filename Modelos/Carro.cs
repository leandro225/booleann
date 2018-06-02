using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelos
{
    public class Carro

    {

        private Boolean estaEstacionado;
        public int CarroID { get; set; }

        public string Placa { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public Boolean EstaEstacionado()
        {
            return estaEstacionado;
        }

        public void setEstaEstacionado(Boolean estaEstacionado)
        {
            this.estaEstacionado = estaEstacionado;
        }
    }
    
}
