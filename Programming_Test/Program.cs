using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkManager parkManager = new ParkManager();

            Elephant ellie = new Elephant("Ellie", EAnimals.Elephant);
            Giraffe giraffie = new Giraffe("Giraffie", EAnimals.Giraffe);
            Worker workie = new Worker("John");

            parkManager.WriteEvent += ParkManager_writeEvent;
            workie.cleaningEvent += Worker_cleaningEvent; ;

            //Add animals
            parkManager.ParkAnimals.Add(ellie);
            parkManager.ParkAnimals.Add(giraffie);

            //Add employees
            parkManager.Employees.Add(workie);

            //Beginning methods
            parkManager.SubScribeAnimalEvents();
            parkManager.BeginPark();
        }


        //This could be rewritten so boht animals and workers use the same writeEvent 
        private static void Worker_cleaningEvent(Worker worker, Poop poopToClean)
        {
            Console.WriteLine(worker.Name + "cleaned up a/an " + poopToClean.GetType().Name);
        }

        //This method is not reusable like this
        private static void ParkManager_writeEvent(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }
    }
}
