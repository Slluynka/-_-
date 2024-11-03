/*using System;
using System.Xml.Linq;
namespace Успадкуванняя_основи
{
    class Fruit
    {
        protected string Name;
        public Fruit(string name)
        {
            this.Name = name;
        }
        static void Main(string[] args)
        {
            Fruit fruit1 = new Fruit("Banana");
            Apple apple1 = new Apple("Apple", "Golden", "yellow");
            Pear pear1 = new Pear("Pear", "Santa-Maria", "orange");
            apple1.GetInfo();
            pear1.GetInfo();
            Console.ReadLine();
        }
    }
    class Apple : Fruit
    {
        public string Variety;
        public string Color;

        public Apple(string name1, string variety, string color) : base(name1)
        {
            this.Variety = variety;
            this.Color = color;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Назва фрукта: {Name}; Вид фрукта: {Variety}; Колір фрукта: {Color}"); 
        }

    }

        class Pear : Fruit
        {
            string Variety;
            string Color;
        //base перепитати 
            public Pear(string name, string variety, string color) : base(name)
            {
                this.Variety = variety;
                this.Color = color;
            }
        public void GetInfo()
        {
            Console.WriteLine($"Назва фрукта: {Name}; Вид фрукта: {Variety}; Колір фрукта: {Color}");
        }
    }
    
   
    }*/