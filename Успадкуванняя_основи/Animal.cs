using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Успадкуванняя_основи
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }

        public Animal(string color, float weight)
        { 
            Weight = weight;
            Color = color;
        }
        public abstract string MakeSound();
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("black", 4, 30);
            Console.WriteLine(cat1.Color);
            Console.WriteLine(cat1.MakeSound());
            Console.WriteLine(cat1.ToString());
            Console.ReadLine();
        }


    }
    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }
        public AnimalWithTail (string color, float weight, float tailLength) : base( color, weight )
        { 
            TailLength = tailLength;
        }
    }
    public class Cat : AnimalWithTail
    { 
        public Cat (string color, float weight, float tailLength) : base ( color, weight, tailLength )
        {
           
        }
        private string Purr()
        {
            return "purrrr";
        }
        private string Meow()
        {
            return "meow";
        }
        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        { return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}"; }

    }
    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {

        }
        public override string MakeSound()
        { return "woof"; }
        public override string ToString()
        { return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}"; }
    }

}
