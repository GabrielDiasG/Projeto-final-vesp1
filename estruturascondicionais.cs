using System;

namespace Estruturas_Condicionais___perguntas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
           
            while (true)
            {
                menu1();
                a = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (a)
                {
                    case 1:
                        menor1();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        maio1();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        nivel1();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Você digitou o número errado.\nClique 'Enter' para voltar.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
        public static void menu1()
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("");
            Console.WriteLine("Menor númaro do usuário: 1");
            Console.WriteLine("Maior númaro do usuário: 2");
            Console.WriteLine("Nível de urgência: 3");
        }
        static void menor1()
        {
            float a = 0.0f, b = 0.0f, c = 0.0f;

            Console.WriteLine("Digita primero número do usuário: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita segundo número do usuário: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita terceiro número do usuário: ");
            c = float.Parse(Console.ReadLine());
            Console.Clear();

            if(a < b && a < c)
            {
                Console.WriteLine(a+" é menor que "+b+" e "+c);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b+" é menor que "+a+" e "+c);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c+" é menor que "+a+" e "+b);
            }
            else
            {
                Console.WriteLine("Os valores são iquais!");
            }
        }
        static void maio1()
        {
            float a = 0.0f, b = 0.0f, c = 0.0f;

            Console.WriteLine("Digita primero número do usuário: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita segundo número do usuário: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita terceiro número do usuário: ");
            c = float.Parse(Console.ReadLine());
            Console.Clear();

            if (a > b && a > c)
            {
                Console.WriteLine(a+" é maior que "+b+" e "+c);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " é maior que " + a + " e " + c);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c+" é maior que "+a+" e "+b);
            }
            else
            {
                Console.WriteLine("Os valores são iquais!");
            }
        }
        static void nivel1()
        {
            int a = 0;
            Console.WriteLine("Digita nível de urgência: ");
            a = int.Parse(Console.ReadLine());
            Console.Clear();

            if (a >= 0 && a <= 3)
            {
                Console.WriteLine("BAIXO");
            }
            else if (a >= 3 && a <= 6)
            {
                Console.WriteLine("MÉDIO");
            }
            else if (a >= 6 && a <= 9)
            {
                Console.WriteLine("ALTO");
            }
            else
            {
                Console.WriteLine("Se passou acima de 10, lascou de vez!");
            }
        }
    }
}