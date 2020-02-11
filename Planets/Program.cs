using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet(0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88, 47.4f, 167, 0, false);
            Planet venus = new Planet(4.87f, 12.104f, 5243, 8.9f, -5832.5f, 2802, 108.2f, 224.7f, 35, 464, 0, false);
            Planet earth = new Planet(5.97f, 12.756f, 5514, 9.8f, 23.9f, 24, 149.6f, 365.2f, 29.8f, 15, 1, true);

            List<Planet> planets = new List<Planet>()
            {
                mercury,earth
            };
            
            foreach (Planet planet in planets)
            {
                Console.WriteLine(planet);
            }

            planets.Insert(1, venus);
            planets.RemoveAt(2);
            planets.Add(earth);
            List<Planet> ringSystemPlanets = planets.FindAll(planet => planet.HasRingSystem = true);
            
            Console.WriteLine(planets.Count);
            foreach (Planet planet in ringSystemPlanets)
            {
                Console.WriteLine(planet + "I am ring system");
            }

            List<Planet> thiccMassPlanets = planets.FindAll(planet => planet.Mass > 1 && planet.Mass < 6);
            planets.Clear();

            Console.ReadKey();
        }
    }
}
