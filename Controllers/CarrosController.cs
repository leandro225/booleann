using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controllers
{
    public class CarrosController
    {
         static List<Carro> MeusCarrosSalvos = new List<Carro>();
        //static int ultimoID = 0;

        public static void SalvarCarrosCadastrados(Carro carro)
        {
            Contexto ctx = new Contexto();
            ctx.Carros.Add(carro);
            ctx.SaveChanges();

        }



        public static List<Carro> retornaTodosCarros()
        {
            Contexto ctx = new Contexto();
            return ctx.Carros.ToList();
        }

        //public static List <Carro> PesquisaCarroPorStatus()
        //{
        //    List<Carro> auxiliar = new List<Carro>();
        //    Contexto ctx = new Contexto();
        //    List<Carro> lista = ctx.Carros.ToList();
           
        //    foreach (var item in lista)
        //    {
        //        if (item.EstaEstacionado() == true)
        //        {
        //            auxiliar.Add(item);

        //        }
        //    }
        //    return auxiliar;

        //}
       

        public static Carro PesquisaCarroPorPlaca(string pla)
        {
            Contexto ctx = new Contexto();
            List<Carro> lista = ctx.Carros.ToList();
            foreach (var item in lista)
            {
                if (item.Placa == pla)
                {
                    return item;

                }
            }
            return null;

        }
        /*
         public void EstacionarCarro(int id)
        {
            Contexto ctx = new Contexto();

            // List<Carro> lista = ctx.Carros.ToList();
            Carro c = ctx.Carros.Find(id);
            c.Status = true;
            ctx.SaveChanges();
            

        }*/
        public void LiberarCarro(int id)
        {
            Contexto ctx = new Contexto();

            // List<Carro> lista = ctx.Carros.ToList();
            Carro c = ctx.Carros.Find(id);
            c.Status = false;
            ctx.SaveChanges();


        }

        public static Carro retornaCarroPorId(int id)
        {
            Contexto ctx = new Contexto();
            Carro c = ctx.Carros.Find(id);
            return c;
        }

        /*public static void darEntradaNoEstacionamento(Carro entrada)
        {
            entrada.setEstaEstacionado(true);

        }

        public static void darSaidaDoEstacionamento(Carro entrada)
        {
            entrada.setEstaEstacionado(false);
        }
        */
    }

}