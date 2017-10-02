using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Pet
    {
        public string race;

        public Dog(string classification, int age, string name, string race) : base(classification, age, name)
        {
            this.race = race;
        }
    }
}
