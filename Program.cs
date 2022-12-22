using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();





        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;


            }



        }


        static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float soma = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {soma}.");
            Console.ReadKey();
            Menu();


        }

        static void Subtracao()

        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float sub = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {sub}.");
            Console.ReadKey();
            Menu();




        }

        static void Divisao()
        {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float div = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {div}.");
            Console.ReadKey();
            Menu();


        }

        static void Multiplicacao()
        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float multi = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {multi}.");
            Console.ReadKey();
            Menu();


        }







    }
}
