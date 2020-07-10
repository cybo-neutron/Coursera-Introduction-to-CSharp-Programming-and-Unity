using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of angles and distances");
            Console.WriteLine("============================================");
            Console.WriteLine();

            Console.Write("Enter the value of x for the first point: ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the value of y for the first point: ");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the value of x for the second point: ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Enter the value of y for the second point: ");
            float y2 = float.Parse(Console.ReadLine());


            double delX = x2 - x1;
            double delY = y2 - y1;

            //double distance = Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2));
            double distance = Math.Sqrt(delX * delX + delY * delY);
            double angle = Math.Atan2(delY, delX)*180/Math.PI;


            Console.WriteLine("============================================");
           
            Console.WriteLine("Distance between the two points :{0:f3} " ,distance);
            Console.WriteLine("Angle: {0:f3}", angle);

            Console.Read();
        }
    }
}
