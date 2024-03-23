using System;

namespace Exercise_01_Box
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, heigth);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae) 
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
