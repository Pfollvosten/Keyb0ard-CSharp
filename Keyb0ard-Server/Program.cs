using System;
using RaspberryPiDotNet;

namespace Keyb0ard_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raspberry Pi");

            GPIOMem button = new GPIOMem(GPIOPins.V2_Pin_P1_16);
            while (true)
            {
                Console.WriteLine(button.Read().ToString());
            }
        }
    }
}
