using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskVS
{
    class Dog : Domestic
    {
        public string Type;

        public Dog(string type, string name, int weight, int age) : base(name, weight, age)
        {
            Type = type;
        }
        public string FullInfo()
        {
            return $"Type:{Type}, Name:{Name}, Weight:{Weight}, Age:{Age}";
        }
    }
}
