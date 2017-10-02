using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Programmer : Human
    {
        private string language;
        private string ide;

        public Programmer(string classification, int age, string name, string language, string ide) : base(classification, age,name)
        {
            this.language = language;
            this.ide = ide;
        }

        public void Work()
        {
            if (fatigue >= 70)
            {
                Console.WriteLine("(WORK) Too tired - fatigue = {0}", fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                fatigue += 30;
                Console.WriteLine("(WORK) Old fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
            }
        }
    }
}
