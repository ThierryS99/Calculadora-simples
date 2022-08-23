using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA DO THIERRY"); //CABEÇALHO
            Console.WriteLine();

            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Digite um número para escolher o tipo de operação:");
            Console.WriteLine("1) Soma");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Divisão");
            Console.WriteLine("4) Multiplicação");
            Console.WriteLine();

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }
            Console.WriteLine();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA:");
            Console.Write("Primeiro valor: ");
            float V1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float V2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = V1 + V2;
            Console.WriteLine("O resultado da soma é: {0}", resultado);
            Console.WriteLine();
            Retorno();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO:");
            Console.Write("Primeiro valor: ");
            float V1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float V2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = V1 - V2;
            Console.WriteLine("O resultado da subtração é: {0}", resultado);
            Console.WriteLine();
            Retorno();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO:");
            Console.Write("Primeiro valor: ");
            float V1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float V2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = V1 / V2;
            Console.WriteLine("O resultado da divisão é: {0}", resultado);
            Console.WriteLine();
            Retorno();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO:");
            Console.Write("Primeiro valor: ");
            float V1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float V2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = V1 * V2;
            Console.WriteLine("O resultado da multiplicação é: {0}", resultado);
            Console.WriteLine();
            Retorno();
        }

        static void Retorno()
        {
            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("Digite S para SIM ou N para NÃO.");
            Console.WriteLine();
            string continuar = Console.ReadLine();

            if (continuar == "S" || continuar == "s")
            {
                Menu();
            }
            System.Environment.Exit(0);
        }
    }
}
