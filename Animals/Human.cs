using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals

{
    class Human : Animal
    {
        public string name;
        private Pet pet;
        public Pet Pet
        {
            get
            {
                return pet;
            }
            set
            {
                pet = value;
                value.owner = this;
            }
        }

        public Human(string classification, int age, string name) : base(classification, age)
        {
            this.name = name;
        }

        public void Run(int distance)
        {
            int modifier = distance / 10;

            if(fatigue >= 100-modifier)
            {
                Console.WriteLine("(RUN) Too tired - fatigue = {0}", fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                fatigue += modifier;
                Console.WriteLine("(RUN) Old fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
            }
        }
        public void Play(Pet p)
        {
            if(fatigue >= 65 || p.fatigue >= 65)
            {
                Console.WriteLine("(PLAY HUMAN) Too tired - fatigue = {0}", fatigue);
                Console.WriteLine("(PLAY PET) Too tired - fatigue = {0}", p.fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                int oldPetFatigue = p.fatigue;
                fatigue += 35;
                p.fatigue += 35;
                Console.WriteLine("(PLAY HUMAN) Old fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
                Console.WriteLine("(PLAY PET) Old fatigue = {0}, New fatigue = {1}", oldPetFatigue, p.fatigue);
            }
        }
    }
}
