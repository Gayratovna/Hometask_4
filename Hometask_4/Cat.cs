using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_4
{
    public  class Cat: Animal
    {
        public Cat(string name):
            base(name)
        {
            this.Name = name;
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name}ning ovozi 'myav' ");
        }
    }
}
