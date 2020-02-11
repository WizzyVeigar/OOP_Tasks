using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            WashingMachine washingMachine = new WashingMachine();
            Person Camilla = new Person("Camilla");
            washingMachine.WaterFilledEvent += WaterFilledEvent;

            //these htings are way too big for main
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "What would you like to? \n" +
                    "1. Start washing \n" +
                    "2. Choose washing program \n" +
                    "3. Add washing powder \n" +
                    "4. Remove washing powder \n" +
                    "5. Clean washing machine \n" +
                    "6. Press power button \n" +
                    "7. Open/Close door"
                    );
                string input;
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Camilla.StartWashing(washingMachine);
                        Console.WriteLine("Finished washing");
                        break;
                    case "2":
                        Console.WriteLine(ChooseWasherProgram(washingMachine));
                        break;
                    case "3":
                        Console.WriteLine("How much would you like to add?");
                        int amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(Camilla.AddWashingPowder(washingMachine, amount));
                        break;
                    case "4":
                        Console.WriteLine("How much would you like to remove?");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine(Camilla.RemoveWashingPowder(washingMachine, amount));
                        break;
                    case "5":
                        Console.WriteLine(Camilla.CleanWasher(washingMachine));
                        break;
                    case "6":
                        Console.WriteLine(Camilla.TurnOnTurnOff(washingMachine));
                        break;
                    case "7":
                        Console.WriteLine(Camilla.OpenCloseDoor(washingMachine));
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }

        //Choose what washing program to run
        private static string ChooseWasherProgram(WashingMachine washer)
        {
            string temp;
            Console.WriteLine("Pick a wash¨\n" +
                "1. Clean program \n " +
                "2. Heavy program \n" +
                "3. Normal program \n" +
                "4. Small program");
            temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    washer.chosenProgram = WashingMachine.WashingPrograms.CLEANPROGRAM;
                    return "You chose 1";
                case "2":
                    washer.chosenProgram = WashingMachine.WashingPrograms.HEAVYWASH;
                    return "You chose 2";
                case "3":
                    washer.chosenProgram = WashingMachine.WashingPrograms.NORMALWASH;
                    return "You chose 3";
                case "4":
                    washer.chosenProgram = WashingMachine.WashingPrograms.SMALLWASH;
                    return "You chose 4";
                default:
                    return "Something went wrong with your input";
            }
        }

        private static void WaterFilledEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Water has been filled in the washing machine");
        }
    }
}
