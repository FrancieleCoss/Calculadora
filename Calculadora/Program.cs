using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NovoProjeto
{
    class program
    { 
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool saiu = false;
            while (!saiu)
            {
                Console.WriteLine("Seja bem vindo a Calculadora \n Selecione uma das opções abaixo:");
                Console.WriteLine(" (1) Soma \n (2) Subtração \n (3) Divisão \n (4) Mulplicação\n (5) Potencia\n (6)Raiz\n (7)Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtração:
                        Subtração();
                        break;

                    case Menu.Divisão:
                        Divisão();
                        break;

                    case Menu.Multiplicação:
                        Multiplicação();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        saiu = true;
                        break;
                }
                Console.Clear();
            }
            
            static void Soma()
            {
                Console.WriteLine("Bem vindo a calculadora de somar! \n Digite o primeiro número\n");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 + n2;
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Subtração ()
            {
                Console.WriteLine("Bem vindo a calculadora de subtração! \n Digite o primeiro número\n");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 - n2;
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Divisão()
            {
                Console.WriteLine("Bem vindo a calculadora de divisão! \n Digite o primeiro número\n");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int n2 = int.Parse(Console.ReadLine());

                float resultado = (float)n1 / (float)n2;
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Multiplicação()
            {
                Console.WriteLine("Bem vindo a calculadora de multiplicação! \n Digite o primeiro número\n");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 * n2;
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Potencia()
            {
                Console.WriteLine("Bem vindo a calculadora de potencia! \n Digite a base\n");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente");
                int expoente = int.Parse(Console.ReadLine());

                double resultado = Math.Pow(baseNum, expoente);
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }

            static void Raiz()
            {
                Console.WriteLine("Bem vindo a calculadora de raiz! \n Digite número\n");
                int raiz = int.Parse(Console.ReadLine());

                double resultado = Math.Sqrt(raiz);
                Console.WriteLine("O resultado da soma foi:" + resultado);
                Console.WriteLine("Aperte ENTER para voltar ao menu");
                Console.ReadLine();
            }






        }
    }
}