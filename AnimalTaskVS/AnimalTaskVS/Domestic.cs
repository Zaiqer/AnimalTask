using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskVS
{
    class Domestic : Animal
    {
        public string Name;

        public Domestic(string name, int weight, int age) : base(weight, age)
        {
            Name = name;
        }
    }
}
