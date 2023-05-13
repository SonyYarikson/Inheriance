using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public class Scooter : Transport
        {
            public int TireRadius { get; set; }
            public int WheelLenght { get; set; }
            public void PrintInfoScooter()
            {
                Console.WriteLine("Радиус Колеса: " + TireRadius);
                Console.WriteLine("Длина Руля: " + WheelLenght);
            }
        }
    }
}
