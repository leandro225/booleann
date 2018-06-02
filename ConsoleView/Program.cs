using Controllers;
using Modelos;
using System;
using System.Collections.Generic;


namespace ConsoleView
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
            Console.WriteLine("4 - Listar Carros Dentro Do Estacionamento");
           

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
                        Carro c = CadastrarCarro();

                       CarrosController cc = new CarrosController();
                       cc.SalvarCarrosCadastrados(c);

                       ExibirDadosCarro(c);

                        break;
                    case OpcoesMenuPrincipal.EntradaDoCarro:
                          EntradaDoCarro();
                        break;
                    case OpcoesMenuPrincipal.SaidaDoCarro:
                        SaidaDoCarro();
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);

        }
        private static Carro CadastrarCarro()
        {
            Carro carros = new Carro();

            Console.Write("Digite a Placa do Veiculo: ");
            carros.Placa = Console.ReadLine();

            Console.Write("Digite o Modelo do Veiculo: ");
            carros.Modelo = Console.ReadLine();

            Console.Write("Digite a Cor Do Veiculo: ");
            carros.Cor = Console.ReadLine();

            //Endereco end = CadastrarEndereco();

            //cli.EnderecoID = end.EnderecoID;
            return carros;
        }

        private static void ExibirDadosCarro(Carro carro)
        {

            Console.WriteLine();

            Console.WriteLine("Placa: " + carro.Placa);
            Console.WriteLine("Modelo: " + carro.Modelo);
            Console.WriteLine("Cor: " + carro.Cor);
       
            

        }
        public static void EntradaDoCarro()
     
        {
            
            //Cliente cli = cc.PesquisarPorNome(nomeCliente);

            CarrosController carros = new CarrosController();

            string busca;

            Console.Write("Informe a Placa do Veiculo ");
            busca = Console.ReadLine();


            CarrosController cc = new CarrosController();
            Carro car = cc.PesquisarPorPlaca(busca);


            if (car != null)
            {
                CarrosController.DarEntradaNoEstacionamento(car);
                Console.WriteLine();
                
                string hora = DateTime.Now.ToString();
                Console.WriteLine("Hora de Entrada " + hora);

                ExibirDadosCarro(car);
               
            }
            else
            {
                Console.WriteLine("Veiculo nao Encontrado");
            }

            



        }
        public static void SaidaDoCarro()

        {
            
            //Cliente cli = cc.PesquisarPorNome(nomeCliente);

            CarrosController carros = new CarrosController();

            string busca;

            Console.Write("Informe a Placa do Veiculo ");
            busca = Console.ReadLine();

            CarrosController cc = new CarrosController();
            Carro car = cc.PesquisarPorPlaca(busca);


            if (car != null)
            {
                CarrosController.DarSaidaNoEstacionamento(car);


                
                string saida = DateTime.Now.ToString();

                //Console.WriteLine("Hora de Entrada " );
                Console.WriteLine("Hora de Saida " + saida);
                Console.WriteLine();
                ExibirDadosCarro(car);
                Console.WriteLine();
                Console.WriteLine("Saida no Estacionamento");
            

            }
            else
            {
                Console.WriteLine("Veiculo nao Encontrado");
            }
        }

    }
}