using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();
        public abstract void Walk();
        public override string ToString()
        {
            return "Name of animal: ";
        }
    }
}
