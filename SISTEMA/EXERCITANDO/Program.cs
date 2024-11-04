using System;
using System.Linq;
using System.Threading;

namespace Aula2exercisios
{
    public class Program
    {
        static void Main(string[] args)
        {
            exibir_cabecalho();
            exibir_opcoes_menu();
        }

        public static void exibir_cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************");
            Console.WriteLine("Projeto de Exercícios");
            Console.WriteLine("Autor: Matheus Ismarsi");
            Console.WriteLine("**************");
            Console.ResetColor();
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.WriteLine("\nSeja bem-vindo ao sistema de exercícios!");
        }

        public static void exibir_opcoes_menu()
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.Write("\nDigite a opção escolhida: ");

            int opcao_escolhida;
            if (!int.TryParse(Console.ReadLine(), out opcao_escolhida))
            {
                Console.WriteLine("\nEntrada inválida! Tente novamente.");
                Thread.Sleep(2000);
                Console.Clear();
                exibir_cabecalho();
                exibir_opcoes_menu();
                return;
            }

            switch (opcao_escolhida)
            {
                case 0:
                    Sair(); // Chama o método Sair para encerrar o programa
                    break;
                case 1:
                    executar_exercisio(1);
                    break;
                case 2:
                    executar_exercisio(2);
                    break;
                case 3:
                    executar_exercisio(3);
                    break;
                case 4:
                    executar_exercisio(4);
                    break;
                case 5:
                    executar_exercisio(5);
                    break;
                case 6:
                    executar_exercisio(6);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    exibir_cabecalho();
                    exibir_opcoes_menu();
                    break;
            }
        }

        private static void executar_exercisio(int numero_exercisio)
        {
            Console.Clear();
            Console.WriteLine($"Exercício {numero_exercisio}");
            Console.WriteLine($"Executando o exercício {numero_exercisio}...\n");

            switch (numero_exercisio)
            {
                case 1:
                    exercisio1();
                    break;
                case 2:
                    exercisio2();
                    break;
                case 3:
                    exercisio3();
                    break;
                case 4:
                    exercisio4();
                    break;
                case 5:
                    exercisio5();
                    break;
                case 6:
                    exercisio6();
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            exibir_cabecalho();
            exibir_opcoes_menu();
        }

        private static void exercisio1()
        {
            Console.WriteLine("Conteúdo do Exercício 1.");
            Console.Clear();
            Console.WriteLine("Verificar Ano Bissexto");
            Console.Write("Digite o ano que deseja verificar: ");

            bool isYearNumber = int.TryParse(Console.ReadLine(), out int ano);
            if (!isYearNumber)
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um ano válido.");
            }
            else
            {
                if (e_bissexto(ano)) // Chama o método e_bissexto para verificar o ano
                {
                    Console.WriteLine($"\nO ano {ano} é bissexto.");
                }
                else
                {
                    Console.WriteLine($"\nO ano {ano} não é bissexto.");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            exibir_cabecalho();
            exibir_opcoes_menu();
        }

        private static void exercisio2()
        {
            Console.WriteLine("Verificar se a letra é uma vogal ou consoante.");
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar; // Lê uma única letra
            Console.WriteLine(); // Pula para a linha seguinte após o caractere

            letra = char.ToLower(letra); // Converte para minúscula

            // Verifica se é uma letra
            if (char.IsLetter(letra))
            {
                // Verifica se é vogal
                if ("aeiou".Contains(letra))
                {
                    Console.WriteLine($"A letra '{letra}' é uma vogal.");
                }
                else
                {
                    Console.WriteLine($"A letra '{letra}' é uma consoante.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira uma letra.");
            }
        }

        private static void exercisio3()
        {
            Console.WriteLine("Cálculo do IMC.");
            Console.Write("Digite o seu peso (em kg): ");
            bool pesoValido = double.TryParse(Console.ReadLine(), out double peso);

            Console.Write("Digite a sua altura (em metros): ");
            bool alturaValida = double.TryParse(Console.ReadLine(), out double altura);

            if (pesoValido && alturaValida && altura > 0) // Verifica se o peso e a altura são válidos
            {
                double imc = peso / (altura * altura);
                Console.WriteLine($"Seu IMC é: {imc:F2}");

                // Classificação do IMC
                if (imc < 18.5)
                {
                    Console.WriteLine("Classificação: Abaixo do peso.");
                }
                else if (imc < 24.9)
                {
                    Console.WriteLine("Classificação: Peso normal.");
                }
                else if (imc < 29.9)
                {
                    Console.WriteLine("Classificação: Acima do peso.");
                }
                else
                {
                    Console.WriteLine("Classificação: Obeso.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira valores válidos para peso e altura.");
            }
        }

        private static void exercisio4()
        {
            Console.WriteLine("Verificação de Data.");
            Console.Write("Digite o dia: ");
            bool diaValido = int.TryParse(Console.ReadLine(), out int dia);

            Console.Write("Digite o mês: ");
            bool mesValido = int.TryParse(Console.ReadLine(), out int mes);

            Console.Write("Digite o ano: ");
            bool anoValido = int.TryParse(Console.ReadLine(), out int ano);

            if (diaValido && mesValido && anoValido)
            {
                try
                {
                    DateTime dataInformada = new DateTime(ano, mes, dia);
                    DateTime dataAtual = DateTime.Now;

                    if (dataInformada < dataAtual)
                    {
                        Console.WriteLine($"A data {dataInformada.ToShortDateString()} é anterior à data atual {dataAtual.ToShortDateString()}.");
                    }
                    else if (dataInformada > dataAtual)
                    {
                        Console.WriteLine($"A data {dataInformada.ToShortDateString()} é posterior à data atual {dataAtual.ToShortDateString()}.");
                    }
                    else
                    {
                        Console.WriteLine("A data informada é igual à data atual.");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Data inválida! Por favor, insira uma data válida.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira valores válidos para dia, mês e ano.");
            }
        }

        private static void exercisio5()
        {
            Console.WriteLine("Verificação da Nota do Aluno.");
            Console.Write("Digite a nota do aluno: ");
            bool notaValida = double.TryParse(Console.ReadLine(), out double nota);

            if (notaValida)
            {
                if (nota >= 7)
                {
                    Console.WriteLine("O aluno está APROVADO.");
                }
                else if (nota >= 5)
                {
                    Console.WriteLine("O aluno está em RECUPERAÇÃO.");
                }
                else
                {
                    Console.WriteLine("O aluno está REPROVADO.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira uma nota válida.");
            }
        }


        private static void exercisio6()
        {
            Console.WriteLine("Verificação de Número Primo.");
            Console.Write("Digite um número: ");
            bool numeroValido = int.TryParse(Console.ReadLine(), out int numero);

            if (numeroValido)
            {
                if (isPrimo(numero))
                {
                    Console.WriteLine($"O número {numero} é PRIMO.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não é PRIMO.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");
            }
        }

        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Encerrando o programa...");
            Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
            Thread.Sleep(3000);
        }

        private static bool e_bissexto(int ano)
        {
            // Retorna true se o ano for bissexto, false caso contrário
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }

        private static bool isPrimo(int numero)
        {
            if (numero <= 1)
                return false; // 0 e 1 não são primos

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false; // Encontrou um divisor, não é primo
            }

            return true; // Se não encontrou divisores, é primo
        }
    }
}
