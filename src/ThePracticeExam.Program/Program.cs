using System;
using ThePracticeExam.Program.Classes;

namespace ThePracticeExam.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a array length: ");
            try
            {
                int length = int.Parse(Console.ReadLine());
                CarControl carControl = new CarControl(length);

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Car {i+1}:");
                    var car = new Car();

                    Console.Write("Enter a model: ");
                    car.Model = Console.ReadLine();

                    Console.Write("Enter a price: ");
                    car.Price = int.Parse(Console.ReadLine());

                    Console.Write("Enter a power: ");
                    car.Power = int.Parse(Console.ReadLine());


                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
