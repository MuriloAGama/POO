using System;
using System.Collections.Generic;
using Zoologico.src;


namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[] {
                    new Gato("Garfield","Marrom","Listras brancas, pequeno",5, 7.6,"Felino"),
                    new Macaco("Cesar", "Preto", "Macaco prego", 8, 25.4,"Primata"),
                    new Cachorro("Pandora","Marrom", "Manchas brancas", 4, 6.10, "Canídio"),

                    }
                );
            List<Animal> animais1 = new List<Animal>();
            animais1.Add(new Cachorro("Garfield", "Marrom", "Listras brancas, pequeno", 5, 7.6, "Felino"));

            foreach (Animal animal in animais1)
            {
                Console.WriteLine(animal.Name);
                if (animal.Classification == "Canídio")
                {
                    Console.WriteLine($"{animal.Name} é um {animal.Classification}");
                    animal.Comunicar("Au Au");
                    animal.Comer("Ração de frango");
                }
            }
        }
    }
}
