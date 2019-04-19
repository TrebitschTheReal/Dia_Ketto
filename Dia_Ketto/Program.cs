using System;

namespace Dia_Ketto
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstTemperatureValue = new ConvertToFarenheit(27.6);

            Console.WriteLine(FirstTemperatureValue.FahrenheitOut);




            Console.ReadLine();
        }
    }
}
