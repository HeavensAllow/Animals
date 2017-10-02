using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals

{
    class Pet : Animal
    {
        public string name;
        public Human owner;

        public Pet(string classification, int age, string name) : base(classification, age)
        {
            this.name = name;
        }

        public void Play(Human h)
        {
            if (h.fatigue >= 65 || fatigue >= 65)
            {
                Console.WriteLine("(RUN PET) Too tired - fatigue = {0}", fatigue);
                Console.WriteLine("(RUN HUMAN) Too tired - fatigue = {0}", h.fatigue);
            }
            else
            {
                fatigue += 35;
                h.fatigue += 35;
            }
        }
    }
}
