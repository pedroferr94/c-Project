using Projeto_C_Sharp;
using System;

namespace Projeto
{
    class Program
    {
        public static void ChangeConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        static void Main(string[] args)
        {

            bool sair = false;
            Empresa empresa = new Empresa();
            Funcionario funcionario = new Funcionario();
            Menus menus = new Menus();

            menus.AnimacaoEntrada();

            do
            {
                Console.Clear();
                menus.MenuPrincipal();
                menus.Desenho7();
                Console.WriteLine("\n======================================================================================================================================");
                ChangeConsoleColor(ConsoleColor.Yellow);
                Console.Write("\n\n BEM VINDO, ESCOLHA UMA OPÇÃO: ");
                ChangeConsoleColor (ConsoleColor.White);
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        //Listar Funcionarios
                        Console.Clear();
                        menus.MenuFuncionarios();
                        empresa.ListarFuncionarios();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine();
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "2":
                        // Alocar Funcionário a um Horário
                        Console.Clear();
                        Menus.MenuHorarios();
                        empresa.AlocarHorario();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "3":
                        // Listar Funcionários por Alocar a um Horário
                        Console.Clear();
                        Menus.MenuHorarios();
                        empresa.ListarFuncionariosHorario();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "4":
                        // Efetuar Pagamento
                        Console.Clear();
                        Menus.MenuPagamento();
                        empresa.EfeturarPagamento();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "5":
                        // Calcular Gastos da Empresa
                        Console.Clear();
                        menus.MenuGastos();
                        empresa.CalcularGastos();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "6":
                        // Guardar Informações em Ficheiro
                        Console.Clear();
                        menus.MenuFicheiros();
                        empresa.GuardarInformacoes();
                        ChangeConsoleColor(ConsoleColor.Yellow);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU PRINCIPAL...");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "9":
                        // Fechar o programa
                        sair = true;
                        menus.AnimacaoSaida();    
                        
                        break;

                    default:
                        // Opção inválida
                        ChangeConsoleColor(ConsoleColor.Red);
                        Console.WriteLine("\n OPÇÃO INVÁLIDA. POR FAVOR, ESCOLHA UMA OPÇÃO VÁLIDA.");
                        ChangeConsoleColor(ConsoleColor.White);
                        Thread.Sleep(1100);
                        Console.Clear();

                        break;
                }
            } while (!sair);
        }
    }
}