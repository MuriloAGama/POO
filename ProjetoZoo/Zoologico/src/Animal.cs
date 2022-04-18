using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Classification { get; set; }

        public Animal() { }

        public Animal(string name, string color, string description, int age, double weight, string classification)
        {
            Name = name;
            Color = color;
            Description = description;
            Age = age;
            Weight = weight;
            Classification = classification;
        }
        public virtual void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Name} está falando: {comunicacao}");
        }
        public virtual void Comer(string comendo)
        {
            Console.WriteLine($"{Name} está comendo {comendo}");
        }
    }

}
