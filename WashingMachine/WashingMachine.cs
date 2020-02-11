using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine_Task
{

    //This could and should be outside of main, so I don't have to access it through the class
    public enum WashingPrograms
    {
        NORMALWASH,
        HEAVYWASH,
        SMALLWASH,
        CLEANPROGRAM
    }
    class WashingMachine
    {
        public event EventHandler WaterFilledEvent;


        public WashingPrograms chosenProgram;

        private bool poweredOn;

        public bool PoweredOn
        {
            get { return poweredOn; }
            set { poweredOn = value; }
        }

        private bool doorOpen;

        public bool DoorOpen
        {
            get { return doorOpen; }
            set { doorOpen = value; }
        }

        private float washingPowder;

        public float WashingPowder
        {
            get { return washingPowder; }
            set
            {
                if (washingPowder > 50)
                    washingPowder = 50;

                washingPowder = value;
            }
        }

        private float washingPowderMax = 50;

        public float WashingPowderMax
        {
            get { return washingPowderMax = 50; }
        }

        private float dirtiness;

        public float Dirtiness
        {
            get { return dirtiness; }
            set { dirtiness = value; }
        }

        private float dirtinessMax = 100;

        public float DirtinessMax
        {
            get { return dirtinessMax = 100; }
        }

        //Fills the washing machine with water
        private void FillWithWater()
        {
            WaterFilledEvent(this, new EventArgs());
        }



        /// <summary>
        /// Does a wash depending on the <paramref name="chosenProgram"/>
        /// </summary>
        /// <param name="chosenProgram"></param>
        public void StartWashing()
        {
            if (poweredOn)
            {
                FillWithWater();
                switch (chosenProgram)
                {
                    case WashingPrograms.NORMALWASH:
                        if (CheckForExceedingValue(12.5f, WashingPowder))
                        {
                            WashingPowder -= 12.5f;
                            Dirtiness += 20f;
                        }
                        //Nocando
                        break;
                    case WashingPrograms.HEAVYWASH:
                        if (!CheckForExceedingValue(30f, WashingPowder))
                        {
                            if (!CheckForExceedingValue(40f, dirtinessMax))
                            {
                                WashingPowder -= 30f;
                                Dirtiness += 40f;

                            }
                        }
                        break;
                    case WashingPrograms.SMALLWASH:
                        WashingPowder -= 5f;
                        Dirtiness += 10f;
                        break;
                    case WashingPrograms.CLEANPROGRAM:
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Checks whether <paramref name="value"/> is bigger than <paramref name="maxValue"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxValue"></param>
        /// <returns>returns true if <paramref name="value"/> exceeds <paramref name="maxValue"/></returns>
        public bool CheckForExceedingValue(float value, float maxValue)
        {
            if (value > maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
