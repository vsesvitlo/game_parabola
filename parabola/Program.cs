// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace parabola;
class Program
{
  
    public static void Main(string[] args)
    {
        float x1 = 0f;
        float x2 = 15f;
        float y1 = 0f;
        float y2 = 0f;
        float dx = 0.5f;
        Console.WriteLine( "Please, enter the amount of H");
        string amountH = Console.ReadLine(); //TODO: ConsoleWrite
        int.TryParse(amountH, out int H);
        float h = (x1 + x2) / 2;
        float k = H;
        float a = (y1 - H) / ((x1 - h) * (x1 - h));

        for(float i = x1; i <= x2; i += dx)
        {
            float y = a * ((i - h) * (i - h) + k);
            Console.WriteLine($"{i},{y}");
        }
    }
}
