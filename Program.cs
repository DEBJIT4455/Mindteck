// See https://aka.ms/new-console-template for more informationusing.system;
using System;
namespace myconsoleapplication
{
    class debjit
    {
        public delegate void Debjitdeligate(string name);
        public delegate void Multideligate(int x, int y);
        public void Multi(int x,int y)
        {
            Console.WriteLine(x * y);

        }
        public void name(string name)
        {
            Console.WriteLine("my name is" +" " + name);

        }
       static void Main(string[] args)
        {
            debjit d = new debjit();
            Debjitdeligate obj1 = new Debjitdeligate(d.name);
            Multideligate obj2 = new Multideligate(d.Multi);
            obj1("Debjit");
            obj2(10, 20);

        }
         
    }

}

