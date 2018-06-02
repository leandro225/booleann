using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controllers
{

    public class EstacionarController
    {

        public static Entrada ultimoCarro = new Entrada();
        public static string UltimaPlaca;
      

       
        public static void GuardaPlaca(string placa)
        {
          UltimaPlaca = placa;
        }

        public static string RetornaPlaca()
        {
            return UltimaPlaca;

        }

     

        public static void SalvarEntrada(Entrada novaEntrada)
        {
            ultimoCarro = novaEntrada; //guarda as informações da última entrada realizada 
          
            Contexto ctx = new Contexto();
            ctx.Estacionados.Add(novaEntrada);
            ctx.SaveChanges();

        }

        public static List<Carro> retornaCarros()
        {
            Contexto ctx = new Contexto();
            return ctx.Carros.ToList();
        }

        public static List<Entrada> retornaEntrada()
        {
            Contexto ctx = new Contexto();
            return ctx.Estacionados.ToList();
        }
        public static List<Entrada> PesquisaCarroPorStatus()
        {
            List<Entrada> auxiliar = new List<Entrada>();
            Contexto ctx = new Contexto();
            List<Entrada> lista = ctx.Estacionados.ToList();

            foreach (var item in lista)
            {
                if (item.EstaEstacionado() == true)
                {
                    auxiliar.Add(item);

                }
            }
            return auxiliar;

        }
        public static void darEntradaNoEstacionamento(Entrada entrada)
        {
            entrada.setEstaEstacionado(true);

        }

        public static void darSaidaDoEstacionamento(Entrada entrada)
        {
            entrada.setEstaEstacionado(false);
        }

    }

}
