using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public class Transport : IComparable
        {
            public string Engine { get; set; }
            public int Color { get; set; }
            public string Mark { get; set; }
            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Transport otherTransport = obj as Transport;
                if (otherTransport != null)
                {
                    return this.Color.CompareTo(otherTransport.Color);
                }
                else
                {
                    throw new ArgumentException("Object is not a Person");
                }
            }
            public void PrintInfo()
            {
                Console.WriteLine("Двигатель: "+Engine);
                Console.WriteLine("Цвет: "+Color);
                Console.WriteLine("Марка: "+Mark);
            }


        }
    }
}
