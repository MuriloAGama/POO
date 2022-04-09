using System;


namespace Exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
             velha. */

            Pessoa Person1, Person2;

            Person1 = new Pessoa();
            Person2 = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            Person1.name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            Person1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            Person2.name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            Person2.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine($"Nome: {Person1.name}");
            Console.WriteLine($"idade: {Person1.age}");
            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine($"Nome: {Person2.name}");
            Console.WriteLine($"idade: {Person2.age}");

            if (Person1.age > Person2.age)
            {
                Console.WriteLine($"Pessoa mais velha: {Person1.name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {Person2.name}");
            }
        }
    }
}
