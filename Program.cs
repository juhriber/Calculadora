using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, raiz;
            double result4, resultP, resultR;
            bool n1Valido, n2Valido, raizValido;

            double A, B, C;
            double Delta, X1, X2;
            bool aValido, bValido, cValido;

            int distancia, tempo, velocidade;
            bool distanciaValido, tempoValido;

            string op, sair;

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("<------Calculadora Simples------>\n");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("<------Operações Basicas------>");

                Console.WriteLine("Soma: +");
                Console.WriteLine("Subtração: -");
                Console.WriteLine("Multiplicação: *");
                Console.WriteLine("Divisão: /");
                Console.WriteLine("Potenciação: P");
                Console.WriteLine("Radiação (Raiz Quadrada): R\n");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("<------Operações Adicionais (Bonus)------>");
                Console.WriteLine();
                Console.WriteLine("Bhaskara: B");
                Console.WriteLine("Velocidade Media: V");
                Console.Write("\n");
                Console.ResetColor(); 
                Console.WriteLine();
                Console.Write("Escolha a Operação que Deseja Utilizar: ");
                op = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "P")
                {
                    Console.Clear();

                    Console.Write("Digite o 1ºNumero: ");
                    n1Valido = double.TryParse(Console.ReadLine(), out numero1);

                    if (!n1Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o 2º Número: ");
                    n2Valido = double.TryParse(Console.ReadLine(), out numero2);

                    if (!n2Valido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    switch (op)
                    {
                        case "+":
                            result4 = numero1 + numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Soma: {Math.Round(result4, 2)}");
                            break;

                        case "-":
                            result4 = numero1 - numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Subtração: {Math.Round(result4, 2)}");
                            break;

                        case "*":
                            result4 = numero1 * numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado de Multiplicação: {Math.Round(result4, 2)}");
                            break;

                        case "/":
                            result4 = numero1 / numero2;
                            Console.WriteLine();
                            Console.WriteLine($"Resultado da Divisão: {Math.Round(result4, 2)}");
                            break;

                        case "P":
                            Console.WriteLine();
                            resultP = numero1 * numero2 / 100;
                            Console.WriteLine($"Resultado de Porcentagem: {Math.Round(resultP, 2)}");
                            break;
                    }
                }
                 else if (op == "R")
                {
                    Console.Clear();

                    Console.Write("Digite o Valor de Raiz Quadrada: ");
                    raizValido = double.TryParse(Console.ReadLine(), out raiz);
                    Console.WriteLine();

                    if (!raizValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    resultR = Math.Sqrt(raiz);
                    Console.WriteLine($"Raiz Quadrada de {raiz}");
                    Console.WriteLine($"É: {Math.Round(resultR, 2)}");
                    Console.WriteLine();
                }
                else if (op == "B")
                {
                    Console.Clear();
                    Console.Write("Digite o Valor de A: ");
                    aValido = double.TryParse(Console.ReadLine(), out A);

                    if (!aValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de B: ");
                    bValido = double.TryParse(Console.ReadLine(), out B);

                    if (!bValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite o Valor de C: ");
                    cValido = double.TryParse(Console.ReadLine(), out C);

                    if (!cValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Delta = Math.Pow(B, 2) - 4 * A * C;
                    X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
                    X2 = (-B - Math.Sqrt(Delta)) / 2 * A;

                    if (A == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Não é uma equação do segundo grau!");
                    }
                    else if (Delta < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Como Delta é = -8,00, a equação não possui raizes reais!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("O resultado de x1 é: ");
                        Console.WriteLine(Math.Round(X1, 2));

                        Console.Write("O resultado de x2 é: ");
                        Console.WriteLine(Math.Round(X2, 2));
                    }
                }
                else if (op == "V")
                {
                    Console.Clear();

                    Console.Write("Digite seu Valor Distancia (m): ");
                    distanciaValido = int.TryParse(Console.ReadLine(), out distancia);

                    if (!distanciaValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    Console.Write("Digite seu Valor Tempo (s): ");
                    tempoValido = int.TryParse(Console.ReadLine(), out tempo);
                    Console.Write("\n");

                    if (!tempoValido)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Você digitou um valor invalido!");
                        Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }

                    velocidade = distancia / tempo;
                    Console.WriteLine("Sua Velocidade Média é = {0} m/s", velocidade);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um valor invalido!");
                    Console.WriteLine("Pressione ENTER para sair, e execute o programa novamente!");
                    Console.ReadKey();
                    Environment.Exit(-1);
                    }

                Console.Write("Deseja Sair? S/N: ");
                sair = Console.ReadLine().ToUpper();
            }
            while (sair != "S" && sair != "SIM");
            Console.WriteLine();
            {
               Console.Clear();
               Console.WriteLine();
               Console.WriteLine(">Sobre mim: ");
               Console.WriteLine();
               Console.WriteLine("Me chamo Juliana, tenho 16 anos, e sou aluna do curso de Informática da ETEC Adolpho Berezin, em Mongaguá/SP. ");
               Console.WriteLine();
               Console.WriteLine(">Sobre o programa: ");
               Console.WriteLine();
               Console.WriteLine("Esse é meu primeiro programa, concluído para o fim do 1° módulo do curso de Informática, resultado de todo o processo aprendido no decorrer do módulo. Espero que gostem!");
               Console.WriteLine();
               Console.WriteLine("Link para o site: https://github.com/juhriber/Calculadora/");

               Console.WriteLine();
               Console.WriteLine("Obrigado Por Utilizar Meu Programa!");
               Console.WriteLine();

               Console.Write("Deseja Sair? S/N: ");
               sair = Console.ReadLine().ToUpper();
            }
        }
    }
}