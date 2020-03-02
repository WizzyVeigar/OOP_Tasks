using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_Test
{
    class Giraffe : Animal
    {
        GiraffePoop giraffePoop;

        public Giraffe(string name, EAnimals typeOfAnimal) : base(name, typeOfAnimal)
        {
            Thread = new Thread(CountDown);
            TypeOfAnimal = typeOfAnimal;
            giraffePoop = new GiraffePoop(1, 5);
        }

        public override event ShittyDelegate ShitEvent;

        public override void CountDown()
        {
            float i = 1000000;

            while (i > 0)
            {
                i -= 0.04f;

                if (i < 0)
                {
                    Shit();
                    i = 1000000;

                }
            }
        }

        public override void Shit()
        {
            ShitEvent(this, giraffePoop);
        }
    }
}
