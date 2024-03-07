using System;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;
using System.Collections.Generic;

namespace bases
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Console.Title = "Matematica Discreta";           
            string logo = @"  __  __       _                       _   _             _____  _                   _        
 |  \/  |     | |                     | | (_)           |  __ \(_)                 | |       
 | \  / | __ _| |_ ___ _ __ ___   __ _| |_ _  ___ __ _  | |  | |_ ___  ___ _ __ ___| |_ __ _ 
 | |\/| |/ _` | __/ _ \ '_ ` _ \ / _` | __| |/ __/ _` | | |  | | / __|/ __| '__/ _ \ __/ _` |
 | |  | | (_| | ||  __/ | | | | | (_| | |_| | (_| (_| | | |__| | \__ \ (__| | |  __/ || (_| |
 |_|  |_|\__,_|\__\___|_| |_| |_|\__,_|\__|_|\___\__,_| |_____/|_|___/\___|_|  \___|\__\__,_|
                                                                                             ";
            Console.WriteLine(logo, Color.Red);
            do
            {
                Console.WriteLine("Escolha a sua opção :");
                Console.WriteLine("\tb - Converter Binário para Decimal");
                Console.WriteLine("\td - Converter Decimal para Binário");
                Console.WriteLine("\ta - Converter Hexadecimal para Decimal");
                Console.WriteLine("\te - Converter Decimal para Hexadecimal");
                Console.WriteLine("\tf - Converter Binario para Hexadecimal");
                Console.WriteLine("\tg - Converter Hexadecimal para Binario");
                Console.WriteLine("\tj - Operacoes (soma, subtração ou multiplicação) em determinadas bases.");
                Console.WriteLine("\tq - Encerra o programa");
                Console.Write("Sua opção ? ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "b":
                        ConverteBinarioParaDecimal();
                        break;
                    case "d":
                        ConverteDecimalParaBinario();
                        break;
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    case "a":
                        ConverteHexaParaDecimal();
                        break;
                    case "e":
                        ConverteDecHexa();
                        break;
                    case "f":
                        ConverteBinarioHexa();
                        break;
                    case "g":
                        ConverteHexaBinario();
                        break;
                    case "j":
                        Console.WriteLine("ESCOLHA A BASE:");
                        Console.WriteLine("a - HEX");
                        Console.WriteLine("b - DECIMAL");
                        Console.WriteLine("c - BINARIO");
                        string op;
                       op = Console.ReadLine();
                        switch (op)
                        {
                            case "b":
                                CalculadoraDec();
                                break;
                            case "a":
                                CalculadoraHex();
                                break;
                            case "c":
                                CalculadoraBina();
                                break;
                        }
                        break;

                }

                Console.ReadKey();
            } while (opcao != "Q" && opcao != "q");
        }
        private static void ConverteDecimalParaBinario()
        {
            Console.WriteLine("Informe o numero decimal a converter");
            string valor = Console.ReadLine();
            string resultado = Conversor.DecimalBinario(valor);
            Console.WriteLine($" O numero {valor} é igual a {resultado} ");
            Console.WriteLine();
        }
        private static void ConverteBinarioParaDecimal()
        {
            Console.WriteLine("Informe o numero binário.");
            string valor = Console.ReadLine();
            int resultado = Conversor.BinarioDecimal(valor);
            Console.WriteLine($" O numero {valor} é igual a {resultado} ");
            Console.WriteLine();
        }
        private static void ConverteHexaParaDecimal()
        {
            Console.WriteLine("Informe o numero Hexa a converter");
            string valor = Console.ReadLine();
            string resultado = Conversor.Hexadecimaldecimal(valor);
        }
        private static void ConverteDecHexa()
        {
            Console.WriteLine("Informe o numero Decimal a converter");
            int valor = Convert.ToInt32(Console.ReadLine());
            int resultado = Conversor.DecimalHexa(valor);
        }
        private static void ConverteBinarioHexa()
        {
            Console.WriteLine("Informe o numero binario a converter:");
            string valor = Console.ReadLine();
            string resultado = Conversor.BinarioHex(valor);

        }

        private static void ConverteHexaBinario()
        {
            Console.WriteLine("Informe o numero Hexadecimal a converter:");
            string valor = Console.ReadLine();
            string resultado = Conversor.HexBinario(valor);
        }
        private static void CalculadoraDec()
        {
            Pilha p = new Pilha(100);
            while (!p.Cheia())
            {
                int num = 0;
                int pilha2 = 0;
                int pilha1 = 0;
                int resul;
                Console.Write("Digite um nº: " +
                              "\n Ou Um Operador: / + - * :  ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    if (p.Vazia())
                    {
                        Console.WriteLine("PRECISA DE MAIS UM VALOR!");
                    }
                    else
                    {
                        pilha1 = p.Desempilhar();
                    }
                    if (!p.Vazia())
                    {
                        pilha2 = p.Desempilhar();
                        resul = pilha1 + pilha2;
                        Console.WriteLine(resul);
                        p.Empilhar(resul);
                    }

                }


                else if (op == "-")
                {
                    if (p.Vazia())
                    {
                        Console.WriteLine("PRECISA DE MAIS UM VALOR!");
                    }
                    else pilha1 = p.Desempilhar();

                    if (!p.Vazia())
                    {
                        pilha2 = p.Desempilhar();
                        resul = (pilha1 - pilha2);
                        Console.WriteLine(resul);
                        p.Empilhar(resul);
                    }
                }
                else if (op == "*")
                {
                    if (p.Vazia())
                    {
                        Console.WriteLine("PRECISA DE MAIS UM VALOR!");
                    }
                    else pilha1 = p.Desempilhar();

                    if (!p.Vazia())
                    {
                        pilha2 = p.Desempilhar();
                        resul = (pilha1 * pilha2);
                        Console.WriteLine(resul);
                        p.Empilhar(resul);
                    }

                }
                else if (op == "/")
                {
                    if (p.Vazia())
                    {
                        Console.WriteLine("PRECISA DE MAIS UM VALOR!");
                    }
                    else pilha1 = p.Desempilhar();
                    if (!p.Vazia())
                    {
                        pilha2 = p.Desempilhar();
                        resul = (pilha1 / pilha2);
                        Console.WriteLine(resul);
                        p.Empilhar(resul);
                    }
                }
                else
                {
                    num = int.Parse(op);
                    p.Empilhar(num);

                }
            }
        }
        private static void CalculadoraHex()
        {
            int num1, num2;
            char operador;

            Console.WriteLine("Digite o primeiro número em hexadecimal:");
            num1 = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine("Digite o segundo número em hexadecimal:");
            num2 = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine("Digite o operador (+, -, * ou /) OU q para sair:");
            operador = Convert.ToChar(Console.ReadLine());

            int resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }

            Console.WriteLine("Resultado: " + resultado.ToString("X"));
            Console.ReadKey();
        }
        private static void CalculadoraBina()
        {
            char operador;
            int num1, num2;
            Console.WriteLine("Informe o 1 numero binario:");
         
           num1 = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine("Informe o 2 numero binario:");
            num2 = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine("Digite o operador (+, -, * ou /):");
            operador = Convert.ToChar(Console.ReadLine());
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }

            Console.WriteLine("Resultado: {0}", Convert.ToString(resultado,2));

        }
    }
    
    
        
}
