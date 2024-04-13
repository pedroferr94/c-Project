using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Menus
    {
        public Menus() { }

        public static void ChangeConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public void MenuPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t     ▄▄▄      ▓█████▄  ▒█████    ██████  ███▄ ▄███▓▓█████  ██▓     ██░ ██  ▒█████   ██▀███  ▓█████   ██████ ");
            Console.WriteLine("\t    ▒████▄    ▒██▀ ██▌▒██▒  ██▒▒██    ▒ ▓██▒▀█▀ ██▒▓█   ▀ ▓██▒    ▓██░ ██▒▒██▒  ██▒▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ");
            Console.WriteLine("\t    ▒██  ▀█▄  ░██   █▌▒██░  ██▒░ ▓██▄   ▓██    ▓██░▒███   ▒██░    ▒██▀▀██░▒██░  ██▒▓██ ░▄█ ▒▒███   ░ ▓██▄   ");
            Console.WriteLine("\t    ░██▄▄▄▄██ ░▓█▄   ▌▒██   ██░  ▒   ██▒▒██    ▒██ ▒▓█  ▄ ▒██░    ░▓█ ░██ ▒██   ██░▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒");
            Console.WriteLine("\t     ▓█   ▓██▒░▒████▓ ░ ████▓▒░▒██████▒▒▒██▒   ░██▒░▒████▒░██████▒░▓█▒░██▓░ ████▓▒░░██▓ ▒██▒░▒████▒▒██████▒▒");
            Console.WriteLine("\t     ▒▒   ▓▒█░ ▒▒▓  ▒ ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░ ▒░   ░  ░░░ ▒░ ░░ ▒░▓  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░");
            Console.WriteLine("\t      ▒   ▒▒ ░ ░ ▒  ▒   ░ ▒ ▒░ ░ ░▒  ░ ░░  ░      ░ ░ ░  ░░ ░ ▒  ░ ▒ ░▒░ ░  ░ ▒ ▒░   ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░");
            Console.WriteLine("\t      ░   ▒    ░ ░  ░ ░ ░ ░ ▒  ░  ░  ░  ░      ░      ░     ░ ░    ░  ░░ ░░ ░ ░ ▒    ░░   ░    ░   ░  ░  ░  ");
            Console.WriteLine("\t          ░  ░   ░        ░ ░        ░         ░      ░  ░    ░  ░ ░  ░  ░    ░ ░     ░        ░  ░      ░   ");
            Console.WriteLine("\t               ░                                                                                             ");
            Console.WriteLine("======================================================================================================================================");
            Console.WriteLine();
            Console.Write("\t  ("); 
            ChangeConsoleColor(ConsoleColor.DarkCyan); 
            Console.Write("1"); 
            ChangeConsoleColor(ConsoleColor.White); 
            Console.Write(") LISTAR FUNCIONÁRIOS  (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("2");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") ATRIBUIR HORARIO FUNCIONARIO  (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("3");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") HORARIOS  (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("4");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") EFETUAR PAGAMENTO  (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("5");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") GASTOS EMPRESA");
            Console.WriteLine("\n");
            Console.Write("\t                                      (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("6");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") GUARDAR EM FICHEIROS  (");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("9");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(") FECHAR PROGRAMA");
            Console.WriteLine("\n");
            Console.WriteLine("======================================================================================================================================");
            Console.WriteLine();


        } 
        public void Desenho()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                 o o");
            Console.WriteLine("                                 o ooo");
            Console.WriteLine("                                   o oo");
            Console.WriteLine("                                      o o      |   #)");
            Console.WriteLine("                                       oo     _|_|_#_    ");
            Console.WriteLine("                                         o   | 5089  |");
            Console.WriteLine("    __                    ___________________|       |_________________");
            Console.WriteLine("   |   -_______-----------                                              \\");
            Console.WriteLine("  >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("   |__ -     ---------_________________________________________________ /");
        }
        public void Desenho2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                 o o");
            Console.WriteLine("                                                 o ooo");
            Console.WriteLine("                                                   o oo");
            Console.WriteLine("                                                      o o      |   #)");
            Console.WriteLine("                                                       oo     _|_|_#_    ");
            Console.WriteLine("                                                         o   | 5089  |");
            Console.WriteLine("                    __                    ___________________|       |_________________");
            Console.WriteLine("                   |   -_______-----------                                              \\");
            Console.WriteLine("                  >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                   |__ -     ---------_________________________________________________ /");
        }
        public void Desenho3()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                                 o o");
            Console.WriteLine("                                                                 o ooo");
            Console.WriteLine("                                                                   o oo");
            Console.WriteLine("                                                                      o o      |   #)");
            Console.WriteLine("                                                                       oo     _|_|_#_    ");
            Console.WriteLine("                                                                         o   | 5089  |");
            Console.WriteLine("                                    __                    ___________________|       |_________________");
            Console.WriteLine("                                   |   -_______-----------                                              \\");
            Console.WriteLine("                                  >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                                   |__ -     ---------_________________________________________________ /");
        }
        public void Desenho4()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                                      o o");
            Console.WriteLine("                                                                      o o      |   #)");
            Console.WriteLine("                                                                       oo     _|_|_#_    ");
            Console.WriteLine("                                                                         o   | 5089  |");
            Console.WriteLine("                                    __                    ___________________|       |_________________");
            Console.WriteLine("                                   |   -_______-----------                                              \\");
            Console.WriteLine("                                  >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                                   |__ -     ---------_________________________________________________ /");
        }
        public void Desenho5()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                                             o o      |   #)");
            Console.WriteLine("                                                                              oo     _|_|_#_    ");
            Console.WriteLine("                                                                                 o   | 5089  |");
            Console.WriteLine("                                            __                    ___________________|       |_________________");
            Console.WriteLine("                                           |   -_______-----------                                              \\");
            Console.WriteLine("                                          >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                                           |__ -     ---------_________________________________________________ /");
        }
        public void Desenho6()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~oo~~~~|   #)" + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                                                        o o   _|_|_#_    ");
            Console.WriteLine("                                                                                         o   | 5089  |");
            Console.WriteLine("                                                    __                    ___________________|       |_________________");
            Console.WriteLine("                                                   |   -_______-----------                                              \\");
            Console.WriteLine("                                                  >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                                                   |__ -     ---------_________________________________________________ /");
        }
        public void Desenho7()
        {
            Console.WriteLine("                                                                                                   |   #)                              ");
            Console.WriteLine("                                                                                                  _|_|_#_                              ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~| 5089  | "+ "~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                                        __                    ___________________|       |_________________");
            Console.WriteLine("                                                       |   -_______-----------                                              \\");
            Console.WriteLine("                                                      >|    _____                ADOSMELHORES                       --->     )");
            Console.WriteLine("                                                       |__ -     ---------_________________________________________________ /");
        }
        public void AnimacaoEntrada()
        {
            Console.Clear();
            ChangeConsoleColor(ConsoleColor.White);
            Desenho();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho2();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho3();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho4();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho5();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho6();
            Thread.Sleep(0400);
            Console.Clear();
            Desenho7();
        }
        public void AnimacaoSaida()
        {
            Console.Clear();
            Desenho7();
            Thread.Sleep(0300);
            Console.Clear();
            ChangeConsoleColor(ConsoleColor.White);
            Desenho6();
            Thread.Sleep(0300);
            Console.Clear();
            Desenho5();
            Thread.Sleep(0300);
            Console.Clear();
            Desenho4();
            Thread.Sleep(0300);
            Console.Clear();
            Desenho3();
            Thread.Sleep(0300);
            Console.Clear();
            Desenho2();
            Thread.Sleep(0300);
            Console.Clear();
            Desenho();
            Console.WriteLine("\n======================================================================================================================================");
            Encerrado();
        }
        public void MenuFuncionarios()
        {
            Console.WriteLine();
            Console.WriteLine("  ██▓     ██▓  ██████ ▄▄▄█████▓ ▄▄▄           █████▒█    ██  ███▄    █  ▄████▄   ██▓ ▒█████   ███▄    █  ▄▄▄       ██▀███   ██▓ ▒█████    ██████ ");
            Console.WriteLine(" ▓██▒    ▓██▒▒██    ▒ ▓  ██▒ ▓▒▒████▄       ▓██   ▒ ██  ▓██▒ ██ ▀█   █ ▒██▀ ▀█  ▓██▒▒██▒  ██▒ ██ ▀█   █ ▒████▄    ▓██ ▒ ██▒▓██▒▒██▒  ██▒▒██    ▒ ");
            Console.WriteLine(" ▒██░    ▒██▒░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄     ▒████ ░▓██  ▒██░▓██  ▀█ ██▒▒▓█    ▄ ▒██▒▒██░  ██▒▓██  ▀█ ██▒▒██  ▀█▄  ▓██ ░▄█ ▒▒██▒▒██░  ██▒░ ▓██▄  ");
            Console.WriteLine(" ▒██░    ░██░  ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██    ░▓█▒  ░▓▓█  ░██░▓██▒  ▐▌██▒▒▓▓▄ ▄██▒░██░▒██   ██░▓██▒  ▐▌██▒░██▄▄▄▄██ ▒██▀▀█▄  ░██░▒██   ██░  ▒   ██▒");
            Console.WriteLine(" ░██████▒░██░▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒   ░▒█░   ▒▒█████▓ ▒██░   ▓██░▒ ▓███▀ ░░██░░ ████▓▒░▒██░   ▓██░ ▓█   ▓██▒░██▓ ▒██▒░██░░ ████▓▒░▒██████▒▒");
            Console.WriteLine(" ░ ▒░▓  ░░▓  ▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░    ▒ ░   ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒ ░ ░▒ ▒  ░░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ▒▒   ▓▒█░░ ▒▓ ░▒▓░░▓  ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░");
            Console.WriteLine(" ░ ░ ▒  ░ ▒ ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░    ░     ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░  ▒    ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░  ▒   ▒▒ ░  ░▒ ░ ▒░ ▒ ░  ░ ▒ ▒░ ░ ░▒  ░ ░");
            Console.WriteLine("   ░ ░    ▒ ░░  ░  ░    ░        ░   ▒       ░ ░    ░░░ ░ ░    ░   ░ ░ ░         ▒ ░░ ░ ░ ▒     ░   ░ ░   ░   ▒     ░░   ░  ▒ ░░ ░ ░ ▒  ░  ░  ░  ");
            Console.WriteLine("     ░  ░ ░        ░                 ░  ░             ░              ░ ░ ░       ░      ░ ░           ░       ░  ░   ░      ░      ░ ░        ░  ");
            Console.WriteLine("                                                                       ░                                                                         ");

        }
        public static void MenuHorarios()
        {
            Console.WriteLine();
            Console.WriteLine("  ██░ ██  ▒█████   ██▀███   ▄▄▄       ██▀███   ██▓ ▒█████    ██████ ");
            Console.WriteLine(" ▓██░ ██▒▒██▒  ██▒▓██ ▒ ██▒▒████▄    ▓██ ▒ ██▒▓██▒▒██▒  ██▒▒██    ▒ ");
            Console.WriteLine(" ▒██▀▀██░▒██░  ██▒▓██ ░▄█ ▒▒██  ▀█▄  ▓██ ░▄█ ▒▒██▒▒██░  ██▒░ ▓██▄   ");
            Console.WriteLine(" ░▓█ ░██ ▒██   ██░▒██▀▀█▄  ░██▄▄▄▄██ ▒██▀▀█▄  ░██░▒██   ██░  ▒   ██▒");
            Console.WriteLine(" ░▓█▒░██▓░ ████▓▒░░██▓ ▒██▒ ▓█   ▓██▒░██▓ ▒██▒░██░░ ████▓▒░▒██████▒▒");
            Console.WriteLine("  ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░░▓  ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░");
            Console.WriteLine("  ▒ ░▒░ ░  ░ ▒ ▒░   ░▒ ░ ▒░  ▒   ▒▒ ░  ░▒ ░ ▒░ ▒ ░  ░ ▒ ▒░ ░ ░▒  ░ ░");
            Console.WriteLine("  ░  ░░ ░░ ░ ░ ▒    ░░   ░   ░   ▒     ░░   ░  ▒ ░░ ░ ░ ▒  ░  ░  ░  ");
            Console.WriteLine("  ░  ░  ░    ░ ░     ░           ░  ░   ░      ░      ░ ░        ░  ");
            Console.WriteLine("                                                                    ");
            Console.WriteLine();
        }
        public static void MenuPagamento()
        {
            Console.WriteLine();
            Console.WriteLine(" ██▓███   ▄▄▄        ▄████  ▄▄▄       ███▄ ▄███▓▓█████  ███▄    █ ▄▄▄█████▓ ▒█████  ");
            Console.WriteLine("▓██░  ██▒▒████▄     ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀  ██ ▀█   █ ▓  ██▒ ▓▒▒██▒  ██▒");
            Console.WriteLine("▓██░ ██▓▒▒██  ▀█▄  ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   ▓██  ▀█ ██▒▒ ▓██░ ▒░▒██░  ██▒");
            Console.WriteLine("▒██▄█▓▒ ▒░██▄▄▄▄██ ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ ▓██▒  ▐▌██▒░ ▓██▓ ░ ▒██   ██░");
            Console.WriteLine("▒██▒ ░  ░ ▓█   ▓██▒░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒▒██░   ▓██░  ▒██▒ ░ ░ ████▓▒░");
            Console.WriteLine("▒▓▒░ ░  ░ ▒▒   ▓▒█░ ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░░ ▒░   ▒ ▒   ▒ ░░   ░ ▒░▒░▒░ ");
            Console.WriteLine("░▒ ░       ▒   ▒▒ ░  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░░ ░░   ░ ▒░    ░      ░ ▒ ▒░ ");
            Console.WriteLine("░░         ░   ▒   ░ ░   ░   ░   ▒   ░      ░      ░      ░   ░ ░   ░      ░ ░ ░ ▒  ");
            Console.WriteLine("               ░  ░      ░       ░  ░       ░      ░  ░         ░              ░ ░  ");
            Console.WriteLine();
            Console.WriteLine();

        }
        public void MenuGastos()
        {
            Console.WriteLine();
            Console.WriteLine("   ▄████  ▄▄▄        ██████ ▄▄▄█████▓ ▒█████    ██████ ");
            Console.WriteLine("  ██▒ ▀█▒▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒▒██    ▒ ");
            Console.WriteLine(" ▒██░▄▄▄░▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒░ ▓██▄   ");
            Console.WriteLine(" ░▓█  ██▓░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒██   ██░  ▒   ██▒");
            Console.WriteLine(" ░▒▓███▀▒ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██████▒▒");
            Console.WriteLine("  ░▒   ▒  ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░");
            Console.WriteLine("   ░   ░   ▒   ▒▒ ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░▒  ░ ░");
            Console.WriteLine(" ░ ░   ░   ░   ▒   ░  ░  ░    ░      ░ ░ ░ ▒  ░  ░  ░  ");
            Console.WriteLine("       ░       ░  ░      ░               ░ ░        ░  ");
            Console.WriteLine("                                                        ");
            Console.WriteLine();
        }
        public void MenuFicheiros()
        {
            Console.WriteLine();
            Console.WriteLine(" █████▒██▓ ▄████▄   ██░ ██ ▓█████  ██▓ ██▀███   ▒█████    ██████");
            Console.WriteLine(" ▓██   ▒▓██▒▒██▀ ▀█  ▓██░ ██▒▓█   ▀ ▓██▒▓██ ▒ ██▒▒██▒  ██▒▒██    ▒");
            Console.WriteLine(" ▒████ ░▒██▒▒▓█    ▄ ▒██▀▀██░▒███   ▒██▒▓██ ░▄█ ▒▒██░  ██▒░ ▓██▄  ");
            Console.WriteLine(" ░▓█▒  ░░██░▒▓▓▄ ▄██▒░▓█ ░██ ▒▓█  ▄ ░██░▒██▀▀█▄  ▒██   ██░  ▒   ██▒");
            Console.WriteLine(" ░▒█░   ░██░▒ ▓███▀ ░░▓█▒░██▓░▒████▒░██░░██▓ ▒██▒░ ████▓▒░▒██████▒▒");
            Console.WriteLine("  ▒ ░   ░▓  ░ ░▒ ▒  ░ ▒ ░░▒░▒░░ ▒░ ░░▓  ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░");
            Console.WriteLine("  ░      ▒ ░  ░  ▒    ▒ ░▒░ ░ ░ ░  ░ ▒ ░  ░▒ ░ ▒░  ░ ▒ ▒░ ░ ░▒  ░ ░");
            Console.WriteLine("  ░ ░    ▒ ░░         ░  ░░ ░   ░    ▒ ░  ░░   ░ ░ ░ ░ ▒  ░  ░  ░   ");
            Console.WriteLine("         ░  ░ ░       ░  ░  ░   ░  ░ ░     ░         ░ ░        ░   ");
            Console.WriteLine("            ░                                                      ");
            Console.WriteLine();
        }
        public void Encerrado()
        {
            Console.WriteLine();
            Console.WriteLine(" ██▓███   ██▀███   ▒█████    ▄████  ██▀███   ▄▄▄       ███▄ ▄███▓ ▄▄▄           █████▒▓█████  ▄████▄   ██░ ██  ▄▄▄      ▓█████▄  ▒█████  ");
            Console.WriteLine("▓██░  ██▒▓██ ▒ ██▒▒██▒  ██▒ ██▒ ▀█▒▓██ ▒ ██▒▒████▄    ▓██▒▀█▀ ██▒▒████▄       ▓██   ▒ ▓█   ▀ ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▒██▀ ██▌▒██▒  ██▒ ");
            Console.WriteLine("▓██░ ██▓▒▓██ ░▄█ ▒▒██░  ██▒▒██░▄▄▄░▓██ ░▄█ ▒▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄     ▒████ ░ ▒███   ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ░██   █▌▒██░  ██▒ ");
            Console.WriteLine("▒██▄█▓▒ ▒▒██▀▀█▄  ▒██   ██░░▓█  ██▓▒██▀▀█▄  ░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██    ░▓█▒  ░ ▒▓█  ▄ ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ░▓█▄   ▌▒██   ██░ ");
            Console.WriteLine("▒██▒ ░  ░░██▓ ▒██▒░ ████▓▒░░▒▓███▀▒░██▓ ▒██▒ ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒   ░▒█░    ░▒████▒▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒░▒████▓ ░ ████▓▒░ ");
            Console.WriteLine("▒▓▒░ ░  ░░ ▒▓ ░▒▓░░ ▒░▒░▒░  ░▒   ▒ ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░    ▒ ░    ░░ ▒░ ░░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░ ▒▒▓  ▒ ░ ▒░▒░▒░  ");
            Console.WriteLine("░▒ ░       ░▒ ░ ▒░  ░ ▒ ▒░   ░   ░   ░▒ ░ ▒░  ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░    ░       ░ ░  ░  ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░ ░ ▒  ▒   ░ ▒ ▒░  ");
            Console.WriteLine("░░         ░░   ░ ░ ░ ░ ▒  ░ ░   ░   ░░   ░   ░   ▒   ░      ░     ░   ▒       ░ ░       ░   ░         ░  ░░ ░  ░   ▒    ░ ░  ░ ░ ░ ░ ▒   ");
            Console.WriteLine("            ░         ░ ░        ░    ░           ░  ░       ░         ░  ░              ░  ░░ ░       ░  ░  ░      ░  ░   ░        ░ ░   ");
            Console.WriteLine("                                                                                             ░                           ░               ");

        }
    }
}
