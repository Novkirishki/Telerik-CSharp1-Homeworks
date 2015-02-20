using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input height");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The perimeter is: " + (2*width + 2*height) + " and the area: " + (width*height));
        }
    }
}
