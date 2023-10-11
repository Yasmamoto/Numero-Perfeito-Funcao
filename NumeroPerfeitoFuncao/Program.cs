using System;

class NumeroPerfeito
{
   
    static int VerificarPerfeitos(int numeroConta)
    {
        int soma = 0;

        for (int i = 1; i < numeroConta; i++)
        {
            if (numeroConta % i == 0)
            {
                Console.WriteLine("\n\n--------------------------------------------");

                Console.WriteLine($"\n  Um dos divisores de {numeroConta} é: {i}");

                Console.WriteLine("\n--------------------------------------------");
                soma+= i;
            }

        }
        return soma;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(" -####################################################- ");
        Console.WriteLine("|                                                      |");
        Console.WriteLine("|   Programa para descobrir se um número é perfeito    |");
        Console.WriteLine("|                                                      |");            
        Console.WriteLine(" -####################################################- ");

        Console.Write("\n  Digite um número -->  ");

        string numeroEntrada = Console.ReadLine();
        int numeroConta = int.Parse(numeroEntrada);

      

        if (VerificarPerfeitos(numeroConta) == numeroConta)
        {
            Console.WriteLine("\n\n********************************************");

            Console.WriteLine($"\n  {numeroConta} é um número perfeito!!");

            Console.WriteLine("\n********************************************");
        }

        else
        {
            Console.WriteLine("\n\n********************************************");

            Console.WriteLine($"\n  {numeroConta} não é um numero perfeito!!");

            Console.WriteLine("\n********************************************");
        }
        Console.ReadKey();
    }

}
