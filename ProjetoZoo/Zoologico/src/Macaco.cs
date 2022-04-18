using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.src
{
    public class Macaco : Animal
    {
        public Macaco() { }

        public Macaco(string name, string color, string description, int age, double weight, string classification) { }

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