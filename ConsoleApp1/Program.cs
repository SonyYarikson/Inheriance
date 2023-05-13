using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ElectroScooter e1 = new ElectroScooter();
            e1.BatteryCapacity = 300;
            e1.Color = 2;
            e1.Engine = "Electro";
            e1.Mark = "Tesla";
            e1.WheelLenght = 150;
            e1.MaxSpeed = 50;
            e1.TireRadius = 20;
            ElectroScooter e2 = new ElectroScooter();
            e2.BatteryCapacity = 320;
            e2.Color = 1;
            e2.Engine = "Electro";
            e2.Mark = "Subaru";
            e2.WheelLenght = 100;
            e2.MaxSpeed = 40;
            e2.TireRadius = 30;
            PrintProperties(e1);
            Console.WriteLine("------------------");
            PrintProperties(e2);
        }
        static void PrintProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("{0}: {1}", property.Name, property.GetValue(obj));

                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                {
                    PrintProperties(property.GetValue(obj));
                }
            }
        }
    }
}
