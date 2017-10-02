using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals

{
    class Animal
    {
        public string classification;
        public int age;
        public int fatigue = 0;

        public Animal(string classification, int age)
        {
            this.classification = classification;
            this.age = age;
        }

        public void Sleep(int time)
        {
            if(fatigue > 10)
            {
                int oldFatigue = fatigue;
                fatigue -= Convert.ToInt32(time / 60 * 1.5);
                //fatigue = fatigue - Convert.ToInt32(time / 60 * 1.5);
                Console.WriteLine("(SLEEP) Old fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
            }
            else
            {
                Console.WriteLine("(SLEEP) Not tired - fatigue = {0}", fatigue);
            }
        }

        public void Play()
        {
            if (fatigue >= 80)
            {
                Console.WriteLine("(PLAY) Too tired - fatigue = {0}", fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                fatigue += 20;
                Console.WriteLine("(PLAY) Old fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
            }
        }

    }
}
