using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
        public override void Walk()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
