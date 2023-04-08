using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer;
            double time;
            double speed;
            double gravity;

            answer = Calculator.Add(3, 4);
            Console.WriteLine(answer);

            answer = Calculator.Subtract(3, 4);
            Console.WriteLine(answer);
            
            do
            {
                Console.WriteLine("Please enter a gravity");
                gravity = Convert.ToDouble(Console.ReadLine());
                Calculator.SetGravity(gravity);

                Console.WriteLine("Please enter a time");
                time = Convert.ToDouble(Console.ReadLine());

                speed = Calculator.Velocity(time);
                Console.WriteLine(speed + "m/s");

            } while (time != 0);

            Console.ReadKey();
        }
    }
}
