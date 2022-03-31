using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"The result");
            Console.WriteLine($"celcius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");



        }
    }
}
