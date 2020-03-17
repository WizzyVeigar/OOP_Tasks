using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_Test
{
    class Elephant : Animal
    {
        ElephantPoop elephantPoop;

        public override event ShittyDelegate ShitEvent;

        public Elephant(string name, EAnimals typeOfAnimal) : base(name, typeOfAnimal)
        {
            Thread = new Thread(CountDown);
            TypeOfAnimal = typeOfAnimal;
            elephantPoop = new ElephantPoop(2, 3);
        }


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
            ShitEvent(this, elephantPoop);
        }


    }
}
