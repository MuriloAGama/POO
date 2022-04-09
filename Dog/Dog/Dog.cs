using System;

namespace Dog
{
    internal class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; } 
        public string Creed { get; set; }
        public double Size { get; set; }

        public Dog(string _nome, int _Age, int _Weight, string _Color, string _Creed, double _Size)
        {
            Name = _nome;
            Age = _Age;
            Weight = _Weight;
            Color = _Color;
            Creed = _Creed;
            Size = _Size;


        }
        public void Dormir()
        {
            Console.WriteLine("ZzZzZzZzZ...");
        }
        public void Latir()
        {
            Console.WriteLine("AuAuAu");
        }
        public void Comer()
        {
            Console.WriteLine("Está comendo");
        }
    }
}
