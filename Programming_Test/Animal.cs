using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_Test
{
    public enum EAnimals
    {
        Elephant,
        Giraffe,
        Fox,
        Wolf,
        Rabbit
    };

    abstract class Animal
    {
        /// <summary>
        /// Counts down for the next toilet visit
        /// </summary>
        public abstract void CountDown();

        /// <summary>
        /// Starts the shitEvent
        /// </summary>
        public abstract void Shit();

        public delegate void  ShittyDelegate(object obj, Poop poop);
        public abstract event ShittyDelegate ShitEvent;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Each animal has their own thread, as they do no all poop at the same time as their species
        /// </summary>
        private Thread thread;

        public Thread Thread
        {
            get { return thread; }
            set { thread = value; }
        }

        private EAnimals typeOfAnimal;

        public EAnimals TypeOfAnimal
        {
            get { return typeOfAnimal; }
            set { typeOfAnimal = value; }
        }


        protected Animal(string name, EAnimals typeOfAnimal)
        {
            Name = name;
            TypeOfAnimal = typeOfAnimal;
        }


    }
}
