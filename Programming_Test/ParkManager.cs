using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_Test
{
    //I am not sure how to make singleton...
    class ParkManager
    {

        //Event for writing stuff to console
        public event EventHandler WriteEvent;

        //List of all the animals in the park
        private List<Animal> parkAnimals = new List<Animal>();

        public List<Animal> ParkAnimals
        {
            get { return parkAnimals; }
            set { parkAnimals = value; }
        }

        private List<Worker> employees = new List<Worker>();

        public List<Worker> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        //Just like mary
        private List<Poop> pooppInsPark = new List<Poop>();

        public List<Poop> PooppsInPark
        {
            get { return pooppInsPark; }
            set { pooppInsPark = value; }
        }


        //Holds how satisfied people are
        private float happinessMeter;

        public float HappinessMeter
        {
            get { return happinessMeter; }
            set { happinessMeter = value; }
        }

        private float cleanlinessMeter = 100;
        /// <summary>
        /// Represents how dirty the zoo is, causing <see cref="HappinessMeter"/> to rise and fall.
        /// </summary>
        public float CleanlinessMeter
        {
            get { return cleanlinessMeter; }
            set { cleanlinessMeter = value; }
        }


        //Have a thread for indicating time
        private bool parkOpen = true;

        private bool ParkOpen
        {
            get { return parkOpen; }
            set { parkOpen = value; }
        }

        // Runs the whole shabang, Probably does way too much
        /// <summary>
        /// Begins the zoo!
        /// </summary>
        public void BeginPark()
        {
            bool threadStarted = false;

            while (ParkOpen)
            {
                if (!threadStarted)
                {
                    for (int i = 0; i < ParkAnimals.Count; i++)
                    {
                        if(!ParkAnimals[i].Thread.IsAlive)
                            ParkAnimals[i].Thread.Start();
                    }

                    threadStarted = true;
                }

                //If cleanliness != 100
                while (CleanlinessMeter != 100)
                {
                    for (int i = 0; i < PooppsInPark.Count; i++)
                    {
                        //Check for poop priority
                        switch (PooppsInPark[i].PooPriority)
                        {
                            //You should take an employee and lock their thread, so he has to finish cleaning before being assigned somewhere else, but I don't know how to do that
                            //Workers clean
                            case 1:
                                Employees.First().CleanPoo(PooppsInPark[i]);
                                //This should be the employee removing it, not just POOF'ing it.
                                PooppsInPark.Remove(PooppsInPark[i]);
                                break;
                            case 2:
                                Employees.First().CleanPoo(PooppsInPark[i]);
                                break;
                            case 3:
                                Employees.First().CleanPoo(PooppsInPark[i]);
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            default:
                                break;
                        }
                    }
                    //Do another round
                }
                //Guests come and go

                //Thread for guests too
            }

        }

        //Should probably be somewhere else
        /// <summary>
        /// Subscribes all the animals to
        /// </summary>
        public void SubScribeAnimalEvents()
        {
            foreach (Animal animal in parkAnimals)
            {
                switch (animal.TypeOfAnimal)
                {
                    case EAnimals.Elephant:
                        ((Elephant)animal).ShitEvent += Animal_shitEvent;
                        break;
                    case EAnimals.Giraffe:
                        ((Giraffe)animal).ShitEvent += Animal_shitEvent;
                        break;
                    case EAnimals.Fox:

                        break;
                    case EAnimals.Wolf:

                        break;
                    case EAnimals.Rabbit:

                        break;

                    default:
                        break;
                }

            }
        }

        //Having an event that sends to an event might be overkill?
        /// <summary>
        /// An accident has happened and is sent along to the <see cref="WriteEvent"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Animal_shitEvent(object anim, Poop poo)
        {
            PooppsInPark.Add(poo);
            WriteEvent(((Animal)anim).Name + " the " + anim.GetType().Name + " did an oopsie and laid an/a " + poo.GetType(), new EventArgs());
        }
    }
}
