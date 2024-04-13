// CLASSE EMPRESA || FUNÇÃO CALCULAR GASTOS

using Projeto;
using System;

namespace Projeto_C_Sharp
{
    public class Empresa
    {
        public static void ChangeConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        Menus menus = new Menus();

        private Funcionario[] funcionarios = new Funcionario[5];

        private int numFuncionarios = 0; 
        public Empresa()
        {
            InicializarFuncionariosPredefinidos();
        }
        private void InicializarFuncionariosPredefinidos()
        {
            // Criação de funcionários predefinidos
            Funcionario funcionarioA = new Funcionario(1, "Funcionário A", "Rua do Funcionário A, nº 111", "919191919", DateTime.Parse("2024-12-31"), DateTime.Parse("2022-07-02"), 1, "A", "sim", "sim", "sim", "pós-laboral", 10, "SEM HORARIO");
            Funcionario funcionarioB = new Funcionario(2, "Funcionário B", "Rua do Funcionário B, nº 222", "929292929", DateTime.Parse("2024-12-31"), DateTime.Parse("2023-02-16"), 2, "B", "sim", "sim", "não", "pós-laboral", 8, "SEM HORARIO");
            Funcionario funcionarioC = new Funcionario(3, "Funcionário C", "Rua do Funcionário C, nº 333", "939393939", DateTime.Parse("2024-12-31"), DateTime.Parse("2021-05-09"), 3, "C", "sim", "sim", "sim", "pós-laboral", 15, "NOITE");
            Funcionario funcionarioD = new Funcionario(4, "Funcionário D", "Rua do Funcionário D, nº 444", "949494949", DateTime.Parse("2024-12-31"), DateTime.Parse("2020-12-15"), 4, "D", "sim", "sim", "não", "pós-laboral", 7, "DIA");
            Funcionario funcionarioE = new Funcionario(5, "Funcionário E", "Rua do Funcionário E, nº 555", "959595959", DateTime.Parse("2024-12-31"), DateTime.Parse("2022-10-30"), 5, "E", "sim", "sim", "não", "pós-laboral", 20, "DIA");

            // Adiciona os funcionários predefinidos ao vetor de funcionários
            funcionarios[0] = funcionarioA;
            funcionarios[1] = funcionarioB;
            funcionarios[2] = funcionarioC;
            funcionarios[3] = funcionarioD;
            funcionarios[4] = funcionarioE;

            numFuncionarios = 5;

        }
        public void ListarFuncionarios()
        {
            Console.WriteLine();
            Console.WriteLine("=============================================================================================================================================================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("|      ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome      ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("|           ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Morada           ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write(" | ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Contacto  ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Fim Contrato ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Registro Criminal ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Chefe ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Área ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Insenção ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Bônus ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Carro ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Disponibilidade ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("Valor/H ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("|");
            Console.WriteLine("=============================================================================================================================================================================");
            Console.WriteLine("|    |                 |                              |            |              |                   |       |      |          |       |       |                 |         |");

            for (int i = 0; i < numFuncionarios; i++)
            {
                Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} | {funcionarios[i].Morada,-28} | {funcionarios[i].Contacto,-10} | {funcionarios[i].DataFimContrato.ToShortDateString(),-12} | " +
                    $"{funcionarios[i].DataRegistroCriminal.ToShortDateString(),-17} | {funcionarios[i].Chefe,-5} | {funcionarios[i].Area,-4} | {funcionarios[i].Insencao,-7}  | {funcionarios[i].BonusMensal,-5} | {funcionarios[i].Carro,-5} " +
                    $"| {funcionarios[i].Disponibilidade,-7}     | {funcionarios[i].ValorHora,-5}   |");
            }
            Console.WriteLine("|    |                 |                              |            |              |                   |       |      |          |       |       |                 |         |");
            Console.WriteLine("=============================================================================================================================================================================");
        }
        public void AlocarHorario()
        {
            int inputId = 0;
            bool flag = false;

            do
            {
                HorarioFuncionarios();

                ChangeConsoleColor(ConsoleColor.Yellow);
                Console.Write("INSIRA O ID DO FUNCIONÁRIO: ");
                ChangeConsoleColor(ConsoleColor.White);
                int.TryParse(Console.ReadLine(), out inputId);

                for (int i = 0; i < numFuncionarios; i++)
                {

                    if (inputId == funcionarios[i].ID)
                    {
                        flag = true;
                        string horario;

                        Console.Clear();
                        Menus.MenuHorarios();
                        HorarioFuncionarios();

                        do
                        {
                            ChangeConsoleColor(ConsoleColor.Yellow);
                            Console.WriteLine("HORÁRIOS");
                            ChangeConsoleColor(ConsoleColor.White);
                            Console.Write("\n*");
                            ChangeConsoleColor(ConsoleColor.DarkCyan);
                            Console.Write("DIA ");
                            ChangeConsoleColor(ConsoleColor.White);
                            Console.Write("\n*");
                            ChangeConsoleColor(ConsoleColor.DarkCyan);
                            Console.Write("NOITE ");
                            ChangeConsoleColor(ConsoleColor.White);
                            Console.Write("\n*");
                            ChangeConsoleColor(ConsoleColor.DarkCyan);
                            Console.WriteLine("SEM HORÁRIO");
                            ChangeConsoleColor(ConsoleColor.Yellow);

                            Console.Write("\nINSIRA O HORARIO: ");
                            ChangeConsoleColor(ConsoleColor.White);
                            horario = Console.ReadLine();

                            if (horario.ToUpper() != "NOITE" && horario.ToUpper() != "DIA" && horario.ToUpper() != "SEM HORARIO")
                            {
                                Console.Clear();
                                Menus.MenuHorarios();
                                ChangeConsoleColor(ConsoleColor.Red);
                                Console.Write("ERRO: ");
                                ChangeConsoleColor(ConsoleColor.White);
                                Console.WriteLine("NAO EXISTE ESSE HORARIO\n");
                                HorarioFuncionarios();
                            }
                            else if (horario.ToUpper() == funcionarios[i].Horario)
                            {
                                Console.Clear();
                                Menus.MenuHorarios();
                                ChangeConsoleColor(ConsoleColor.Red);
                                Console.Write("ERRO: ");
                                ChangeConsoleColor(ConsoleColor.White);
                                Console.WriteLine("JA ESTÁ ESSE HORÁRIO ATRIBUÍDO\n");
                                HorarioFuncionarios();
                            }
                        } while (horario.ToUpper() != "NOITE" && horario.ToUpper() != "DIA" && horario.ToUpper() != "SEM HORARIO" || horario.ToUpper() == funcionarios[i].Horario);

                        funcionarios[i].Horario = horario.ToUpper();

                        Console.Clear();
                        Menus.MenuHorarios();
                        Console.Write("HORÁRIO ATRIBUÍDO COM ");
                        ChangeConsoleColor(ConsoleColor.Green);
                        Console.WriteLine("SUCESSO");
                    }
                }

                if (inputId == 0)
                {
                    Console.Clear();
                    Menus.MenuHorarios();
                    ChangeConsoleColor(ConsoleColor.Red);
                    Console.Write("ERRO: ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine("CARACTERES INVALIDOS\n");

                }
                else if (!flag)
                {
                    Console.Clear();
                    Menus.MenuHorarios();
                    ChangeConsoleColor(ConsoleColor.Red);
                    Console.Write("ERRO: ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine("FUNCIONÁRIO NÃO ENCONTRADO\n");
                }
            } while (!flag || inputId == 0);
        }
        public void ListarFuncionariosHorario()
        {
            ChangeConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("\nFUNCIONÁRIOS COM HORÁRIO\n");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome           ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("   Horário");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("        |");
            Console.WriteLine("============================================");
            Console.WriteLine("|    |                 |                   |");

            for (int i = 0; i < numFuncionarios; i++)
            {
                if (funcionarios[i].Horario != "SEM HORARIO")
                {
                    Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} |    {funcionarios[i].Horario,-15}|");
                }
            }

            Console.WriteLine("|    |                 |                   |");
            Console.WriteLine("============================================");
            Console.WriteLine();

            ChangeConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("\nFUNCIONÁRIOS SEM HORÁRIO\n");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome           ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("   Horário");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("        |");
            Console.WriteLine("============================================");
            Console.WriteLine("|    |                 |                   |");

            bool semHorarioEncontrado = false;

            for (int i = 0; i < numFuncionarios; i++)
            {
                if (funcionarios[i].Horario == "SEM HORARIO")
                {
                    semHorarioEncontrado = true;
                    Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} |    {funcionarios[i].Horario,-15}|");
                }
            }

            if (!semHorarioEncontrado)
            {
            Console.WriteLine("|     Nenhum funcionário sem horário       |");
            }
            Console.WriteLine("|    |                 |                   |");
            Console.WriteLine("============================================");
            Console.WriteLine();

            ChangeConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("LEGENDA");
            ChangeConsoleColor(ConsoleColor.White);

            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("\n*DIA ");
            ChangeConsoleColor(ConsoleColor.Yellow);
            Console.Write("-> ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("9 AM | 5 PM");

            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("\n*NOITE ");
            ChangeConsoleColor(ConsoleColor.Yellow);
            Console.Write("-> ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("5 PM | 1 AM\n");
        }
        public void HorarioFuncionarios()
        {
            Console.WriteLine("============================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome           ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("   Horário");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine("        |");
            Console.WriteLine("============================================");
            Console.WriteLine("|    |                 |                   |");

            for (int i = 0; i < numFuncionarios; i++)
            {
                Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} |    {funcionarios[i].Horario,-15}|");
            }

            Console.WriteLine("|    |                 |                   |");
            Console.WriteLine("============================================");
            Console.WriteLine();
        }
        public void CalcularGastos()
        {
            int total = 0;
            int gastoFuncionario = 0;
            Console.WriteLine("==========================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("|      ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome      ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Ordenado bruto");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine(" | ");
            Console.WriteLine("==========================================");
            Console.WriteLine("|    |                 |                 |");
            for (int i = 0; i < numFuncionarios; i++)
            {
                gastoFuncionario = funcionarios[i].ValorHora * (8 * 22);
                total += gastoFuncionario;

                Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} | {gastoFuncionario,10}      |");
            }
            Console.WriteLine("|    |                 |                 |");
            Console.WriteLine("==========================================");
            Console.Write($"\nTOTAL DE GASTOS: ");
            ChangeConsoleColor(ConsoleColor.Green);
            Console.WriteLine($" {total}");
            ChangeConsoleColor(ConsoleColor.White);
        }
        public void Ordenados()
        {

            int gastoFuncionario = 0;
            Console.WriteLine("==========================================");
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write("ID ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("|      ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Nome      ");
            ChangeConsoleColor(ConsoleColor.White);
            Console.Write("| ");
            ChangeConsoleColor(ConsoleColor.DarkCyan);
            Console.Write(" Ordenado bruto");
            ChangeConsoleColor(ConsoleColor.White);
            Console.WriteLine(" | ");
            Console.WriteLine("==========================================");
            Console.WriteLine("|    |                 |                 |");
            for (int i = 0; i < numFuncionarios; i++)
            {
                gastoFuncionario = funcionarios[i].ValorHora * (8 * 5 * 4);

                Console.WriteLine($"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} | {gastoFuncionario,10}      |");
            }
            Console.WriteLine("|    |                 |                 |");
            Console.WriteLine("==========================================");

        }
        public void EfeturarPagamento()
        {
            bool flag = false;
            int valorPagar = 0;
            int id = 0;

            do
            {
                Ordenados();

                ChangeConsoleColor(ConsoleColor.Yellow);
                Console.Write("\nINSIRA O ID DO FUNCIONÁRIO: ");
                ChangeConsoleColor(ConsoleColor.White);
                int.TryParse(Console.ReadLine(), out id);

                string nomeFunc = "";

                for (int i = 0; i < numFuncionarios; i++)
                {
                    int gastoFuncionario = funcionarios[i].ValorHora * (8 * 5 * 4);

                    if (funcionarios[i].ID == id)
                    {
                        nomeFunc = funcionarios[i].Nome;
                        flag = true;
                        Console.Clear();
                        Menus.MenuPagamento();
                        Ordenados();

                        do
                        {
                            Console.Write($"\nPAGAMENTO PARA, ");
                            ChangeConsoleColor(ConsoleColor.Green);
                            Console.WriteLine($"{ funcionarios[i].Nome}" );
                            ChangeConsoleColor(ConsoleColor.White);
                            ChangeConsoleColor(ConsoleColor.Yellow);
                            Console.Write("\nVALOR A PAGAR: ");
                            ChangeConsoleColor(ConsoleColor.White);
                            int.TryParse(Console.ReadLine(), out valorPagar);

                            if (valorPagar == 0)
                            {
                                Console.Clear();
                                Menus.MenuPagamento();
                                Ordenados();
                                ChangeConsoleColor(ConsoleColor.Red);
                                Console.Write("\nERRO: ");
                                ChangeConsoleColor(ConsoleColor.White);
                                Console.WriteLine("CARACTERES INVALIDOS");
                            }
                            else if (valorPagar != gastoFuncionario)
                            {
                                Console.Clear();
                                Menus.MenuPagamento();
                                Ordenados();
                                ChangeConsoleColor(ConsoleColor.Red);
                                Console.Write("\nERRO: ");
                                ChangeConsoleColor(ConsoleColor.White);
                                Console.WriteLine("VALOR A PAGAR ERRADO!");
                            }
                        } while (valorPagar != gastoFuncionario);
                    }
                    Console.Clear();
                    Menus.MenuPagamento();
                    Console.Write("\nPAGAMENTO FEITO COM");
                    ChangeConsoleColor(ConsoleColor.Green);
                    Console.Write($" SUCESSO ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine($"PARA , { nomeFunc }");
                }
                if (id == 0)
                {
                    Console.Clear();
                    Menus.MenuPagamento();
                    ChangeConsoleColor(ConsoleColor.Red);
                    Console.Write("ERRO: ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine("CARACTERES INVALIDOS\n");

                }
                else if (!flag)
                {
                    Console.Clear();
                    Menus.MenuPagamento();
                    ChangeConsoleColor(ConsoleColor.Red);
                    Console.Write("ERRO: ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine("FUNCIONÁRIO NÃO ENCONTRADO\n");
                }

            } while (!flag);
        }
        public void GuardarInformacoes()
        {
            bool jaExiste = false;

            do
            {
                ChangeConsoleColor(ConsoleColor.Yellow);
                Console.Write("\nINTRODUZA O NOME DO FICHEIRO: ");
                ChangeConsoleColor(ConsoleColor.White);
                string nomeFicheiro = Console.ReadLine();

                string caminhoDiretorio = @"C:\Users\Asus\OneDrive\Ambiente de Trabalho\C#\imprimir\ficheiros"; // Alterar o caminho conforme necessário

                // Verifica se o arquivo já existe
                string caminhoCompletoArquivo = Path.Combine(caminhoDiretorio, nomeFicheiro + ".txt");
                if (File.Exists(caminhoCompletoArquivo))
                {
                    Console.Clear();
                    menus.MenuFicheiros();
                    ChangeConsoleColor(ConsoleColor.Red);
                    Console.Write("\nERRO: ");
                    ChangeConsoleColor(ConsoleColor.White);
                    Console.WriteLine("O ARQUIVO JÁ EXISTE. POR FAVOR, ESCOLHA UM NOME DIFERENTE");
                    jaExiste = true;
                }
                else
                {
                    jaExiste = false;
                    // Criação da string com as informações
                    string informacoes = "TABELA DE HORÁRIOS:\n\n";
                    informacoes += "============================================\n";
                    informacoes += "| ID |    Horário       |                  |\n";
                    informacoes += "============================================\n";
                    informacoes += "| 1  |    DIA           |    9 AM | 5 PM   |\n";
                    informacoes += "| 2  |    NOITE         |    5 PM | 1 AM   |\n";
                    informacoes += "| 3  |    SEM HORÁRIO   |        ---       |\n";
                    informacoes += "============================================\n\n";

                    informacoes += "LISTA DE FUNCIONÁRIOS:\n\n";
                    informacoes += "=============================================================================================================================================================================\n";
                    informacoes += "| ID |      Nome       |        Morada                |  Contacto  | Fim Contrato | Registro Criminal | Chefe | Área | Insenção | Bônus | Carro | Disponibilidade | Valor/H |\n";
                    informacoes += "=============================================================================================================================================================================\n";
                    for (int i = 0; i < numFuncionarios; i++)
                    {
                        informacoes += $"| {funcionarios[i].ID,-2} | {funcionarios[i].Nome,-15} | {funcionarios[i].Morada,-20} | {funcionarios[i].Contacto,-10} | {funcionarios[i].DataFimContrato.ToShortDateString(),-12} | {funcionarios[i].DataRegistroCriminal.ToShortDateString(),-17} | {funcionarios[i].Chefe,-5} | {funcionarios[i].Area,-4} | {funcionarios[i].Insencao,-7}  | {funcionarios[i].BonusMensal,-5} | {funcionarios[i].Carro,-5} | {funcionarios[i].Disponibilidade,-7}     | {funcionarios[i].ValorHora,-5}   |\n";
                    }
                    informacoes += "=============================================================================================================================================================================\n";

                    informacoes += "\nFUNCIONÁRIOS COM HORÁRIO:\n\n";
                    for (int i = 0; i < numFuncionarios; i++)
                    {
                        if (funcionarios[i].Horario != "SEM HORARIO")
                        {
                            informacoes += $"ID: {funcionarios[i].ID}, Nome: {funcionarios[i].Nome}, Horário: {funcionarios[i].Horario}\n";
                        }
                    }
                    informacoes += "\nFUNCIONÁRIOS SEM HORÁRIO:\n\n";
                    for (int i = 0; i < numFuncionarios; i++)
                    {
                        if (funcionarios[i].Horario == "SEM HORARIO")
                        {
                            informacoes += $"ID: {funcionarios[i].ID}, Nome: {funcionarios[i].Nome}, Horário: {funcionarios[i].Horario}\n";
                        }
                    }

                    informacoes += "\nORDENADOS:\n\n";
                    for (int i = 0; i < numFuncionarios; i++)
                    {
                        int gastoFuncionario = funcionarios[i].ValorHora * (8 * 5 * 4);
                        informacoes += $"ID: {funcionarios[i].ID}, Nome: {funcionarios[i].Nome}, Ordenado bruto: {gastoFuncionario}\n";
                    }

                    informacoes += "\nTOTAL DE GASTOS:\n\n";
                    int total = 0;
                    for (int i = 0; i < numFuncionarios; i++)
                    {
                        int gastoFuncionario = funcionarios[i].ValorHora * (8 * 22);
                        total += gastoFuncionario;
                    }
                    informacoes += $"Total de gastos: {total}\n";



                    // Escrever no arquivo
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(caminhoCompletoArquivo))
                        {
                            writer.WriteLine(informacoes);
                        }
                        Console.Clear();
                        menus.MenuFicheiros();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nA ENIVAR OS DADOS 1%");
                        Thread.Sleep(0300);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        menus.MenuFicheiros();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nA ENIVAR OS DADOS 27%");
                        Thread.Sleep(0300);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        menus.MenuFicheiros();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nA ENIVAR OS DADOS 43%");
                        Thread.Sleep(0300);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        menus.MenuFicheiros();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nA ENIVAR OS DADOS 78%");
                        Thread.Sleep(0450);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        menus.MenuFicheiros();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nA ENIVAR ASOS DADOS 100%");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        menus.MenuFicheiros();
                        Console.Write("\nDADOS GUARDADOS NO FICHEIRO COM ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("SUCESSO");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (Exception ex)
                    {
                        ChangeConsoleColor(ConsoleColor.Red);
                        Console.Write("ERRO: ");
                        ChangeConsoleColor(ConsoleColor.White);
                        Console.WriteLine("OCORREU UM ERRO A SALVAR OS DADOS\n");
                    }
                }
            } while (jaExiste);
        }
    }
}
