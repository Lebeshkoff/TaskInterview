using System;
using Clock;

namespace TaskInterview
{
    /// <summary>
    /// Simple CLI application for fast test Clock library
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AnalogClock analogClock = null;
            bool flag = true;
            while (flag)
            {
                try
                {
                    flag = false;
                    Console.WriteLine("Enter value\n");
                    Console.WriteLine("Hour angle: ");
                    int hour = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Minute angle: ");
                    int minute = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Second angle: ");
                    int second = Int32.Parse(Console.ReadLine());
                    analogClock = new AnalogClock(hour, minute, second);
                }
                catch (ArgumentException e)
                {
                    flag = true;
                    Console.WriteLine(e.Message);
                }
            }
            IClock digitalClock = new AnalogClockToDigitalAdapter(analogClock);
            Console.WriteLine("\n" + analogClock + "\n");
            Console.WriteLine(digitalClock);
            Console.ReadKey();
        }
    }
}
