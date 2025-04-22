using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.Clear();
            Console.WriteLine("Bem-vindo à Calculadora Simples!");

            Console.Write("Digite o primeiro Número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo Número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada (+, -, X, /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado da Soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado da Subtração é: " + resultado);
                    break;
                case 'X':
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado da Multiplicação é: " + resultado);
                    break;
                case '/':
                case ':':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    Console.WriteLine("Divisão por zero não é permitida.");
                    Console.WriteLine("Resultado da Divisão é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.WriteLine("Deseja realizar outra operação? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta == "S" || resposta == "s")
            {
                goto Inicio;
            }
            else
            {
                Console.WriteLine("Obrigado por usar a calculadora!");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
