using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine_Task
{
    class Person
    {
        private string name;

        public Person(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Turns the machine on and off
        public string TurnOnTurnOff(WashingMachine washer)
        {
            if (washer.PoweredOn)
            {
                washer.PoweredOn = false;
                return "Turned off the machine";
            }
            else
            {
                washer.PoweredOn = true;
                return "Turned on the machine";
            }
        }
        //Opens and closes the washing machine door
        public string OpenCloseDoor(WashingMachine washer)
        {
            if (washer.DoorOpen)
            {
                washer.DoorOpen = false;
                return "Closed the door";
            }
            else
            {
                washer.DoorOpen = true;
                return "Opened the door";
            }
        }

        //Starts the desired washing program
        public void StartWashing(WashingMachine washingMachine)
        {
            washingMachine.StartWashing();
        }

        public string CleanWasher(WashingMachine washingMachine)
        {
            washingMachine.Dirtiness -= washingMachine.Dirtiness;
            return "Cleaned the washing machine";
        }

        //Add washing powder to the machine
        public string AddWashingPowder(WashingMachine washingMachine, float powderAmount)
        {
            if (powderAmount + washingMachine.WashingPowder > washingMachine.WashingPowderMax)
                return "You cannot add that amount, there is " + washingMachine.WashingPowder + " in it already";
            washingMachine.WashingPowder += powderAmount;
            return "Filled washing machine with " + powderAmount + "grams of powder, it now has" + washingMachine.WashingPowder;
        }
        //Removes washing powder from the machine
        public string RemoveWashingPowder(WashingMachine washingMachine, float powderAmount)
        {
            if (powderAmount > washingMachine.WashingPowder)
                return "You tried to take too much";
            washingMachine.WashingPowder -= powderAmount;
            return "You took " + powderAmount + " from the washing machine, it now has" + washingMachine.WashingPowder;
        }
    }
}
