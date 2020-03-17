using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Test
{
    class Worker : Person
    {
        public delegate void cleaningDelegate(Worker worker, Poop poopToClean);
        public event cleaningDelegate cleaningEvent;

        public Worker(string name) : base(name)
        {
        }

        /// <summary>
        /// Cleans up the <paramref name="poo"/>
        /// </summary>
        /// <param name="poo"></param>
        public void CleanPoo(Poop poo)
        {
            switch (poo.GetType().Name)
            {
                case  "ElephantPoop":

                    break;
                default:
                    break;
            }
            //How to switch on GetType() ?
            //switch (poo.GetType())
            //{
            //    case 
            //    default:
            //        break;
            //}
            cleaningEvent(this, poo);
        }
    }
}
