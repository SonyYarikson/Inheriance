using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public class ElectroScooter : Scooter
        {
            public int BatteryCapacity { get; set; }
            public int MaxSpeed { get; set; }
            public void PrintInfoElectroScooter()
            {
                Console.WriteLine("Емкость Аккумулятора: "+ BatteryCapacity);
                Console.WriteLine("Максимальная Скорость: " + MaxSpeed);

            }

        }
    }
}
