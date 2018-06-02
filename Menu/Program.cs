using System;
using Models;
using Controller;
using System.Collections.Generic;




namespace Menu
{
    class Program
    {
        enum OpcoesMenuPrincipal

        {
            CadastrarCarro = 1,
            EntradaDoCarro = 2,
            SaidaDoCarro = 3,
            ListarCarrosDentroDoEstacionamento = 4,
            ListarCarrosForaDoEstacionamento = 5,
            Sair = 6
        }
        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("");

            Console.WriteLine("1 - Cadastrar Carro - ");
            Console.WriteLine("2 - Entrada Do Carro");
            Console.WriteLine("3 - Saida Do Carro");
            Console.WriteLine("4 - ListarCarros Dentro Do Estacionamento");
            Console.WriteLine("5 - Listar Carros Fora Do Estacionamento");
         
            Console.WriteLine("6 - Sair");

           
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }


        static void Main(string[] args)
        {

            OpcoesMenuPrincipal opcaoDigitada =
                OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCarro:
                        Cliente c = CadastrarCliente();

                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);

                        ExibirDadosCliente(c);
                        break;
                   
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);

        }

    }
}

