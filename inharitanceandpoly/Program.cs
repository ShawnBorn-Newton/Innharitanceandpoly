using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitanceandpoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new inharitanceandpoly.Boat(2, 500, "white and Yellow", 70.0d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled());

            Automoblie car1 = new Automoblie(4, 20, "red", 5000, 4, 260, 4 );
            car1.Move();
            car1.Color = "Gold";
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());

            Aircraft plane1 = new Aircraft(10, 10, "blue", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled());
        }
    }
}
