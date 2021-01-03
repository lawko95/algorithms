using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Sorting
{
    /// <summary>
    /// An example class to test the various algorithms on
    /// </summary>
    public class Bicycle : IComparable, IComparable<Bicycle>
    {
        public string Brand { get; set; }
        public Color Colour { get; set; }
        public string Personality { get; set; }
        public double Weight { get; set; }

        public Bicycle(string brand, Color colour, string personality, double weight)
        {
            Brand = brand;
            Colour = colour;
            Personality = personality;
            Weight = weight;
        }

        public static void PrintBicycles(Bicycle[] bicycles)
        {
            foreach (Bicycle b in bicycles)
            {
                Console.WriteLine("Brand: " + b.Brand + ", Colour: " + b.Colour + ", Personality: " + b.Personality + ", Weight: " + b.Weight + "kgs");
            }
        }

        /// <summary>
        /// Compare bicycles based on their weight
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public int CompareTo(Bicycle b)
        {
            if (this.Weight < b.Weight)
                return -1;
            if (this.Weight == b.Weight)
                return 0;
            else
                return 1;
        }

        /// <summary>
        /// Cast obj to bicycle and call the generic CompareTo method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return this.CompareTo((Bicycle)obj);
        }
    }
}
