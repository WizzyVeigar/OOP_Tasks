using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Test
{
    class Poop
    {
        private int pooPriority;

        public int PooPriority
        {
            get { return pooPriority; }
            set { pooPriority = value; }
        }

        /// <summary>
        /// How much desctruction an animals poop is worth
        /// </summary>
        private float pooDamage;

        public float PooDamage
        {
            get { return pooDamage; }
            set { pooDamage = value; }
        }

        public Poop(int pooPriority, int pooDamage)
        {
            PooPriority = pooPriority;
            PooDamage = pooDamage;
        }
    }
}
