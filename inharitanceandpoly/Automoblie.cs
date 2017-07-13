using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitanceandpoly
{
    class Automoblie : Vehicle
    {

        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels { get; }
        public int NunberOfDoors { get; }
        public float WheelSize { get; }

        public Automoblie(int seats, int carryingCapacity, string color, double movementSpeed, int numberOfWheels, float wheelSize, int numberOfDoors )
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.numberOfDoors = numberOfDoors;
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
        }
  
    }
}
