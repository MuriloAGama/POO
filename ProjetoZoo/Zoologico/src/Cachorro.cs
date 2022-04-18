using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Cachorro : Animal
    {
        public Cachorro() { }

        public Cachorro(string name, string color, string description, int age, double weight, string classification) 
        {
            Name = name;
            Color = color;
            Description = description;
            Age = age;
            Weight = weight;
            Classification = classification;
        }

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Name} está falando: {comunicacao}");
        }
        public override void Comer(string comendo)
        {
            Console.WriteLine($"{Name} está comendo: {comendo}");
        }
    }
}
