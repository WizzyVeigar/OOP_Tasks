using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Planet
    {
        //Weirdest looking constructor ever
        public Planet
            (float mass, float diameter, float density,
            float gravity, float rotationPeriod, float dayLength,
            float distanceFromSun, float orbitalPeriod, float orbitalVelocity,
            int meanTemperature, int moonAmount, bool hasRingSystem)
        {
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            DayLength = dayLength;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            MoonAmount = moonAmount;
            HasRingSystem = hasRingSystem;
        }

        private float mass;

        public float Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private float diameter;

        public float Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private float density;

        public float Density
        {
            get { return density; }
            set { density = value; }
        }

        private float gravity;

        public float Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        private float rotationPeriod;

        public float RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }

        private float dayLength;

        public float DayLength
        {
            get { return dayLength; }
            set { dayLength = value; }
        }

        private float distanceFromSun;

        public float DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        private float orbitalPeriod;

        public float OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        private float orbitalVelocity;

        public float OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        private int meanTemperature;

        public int MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        private int moonAmount;

        public int MoonAmount
        {
            get { return moonAmount; }
            set { moonAmount = value; }
        }

        private bool hasRingSystem;


        public bool HasRingSystem
        {
            get { return hasRingSystem; }
            set { hasRingSystem = value; }
        }

    }
}
