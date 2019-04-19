using System;

namespace Dia_Ketto
{
    class ConvertToFarenheit
    {
        double celsiusIn;
        double fahrenheitOut;

        public ConvertToFarenheit(double celsiusIn)
        {
            this.celsiusIn = celsiusIn;
            fahrenheitOut = celsiusIn * 9 / 5 + 32;
        }

        public double FahrenheitOut
        {
            get { return fahrenheitOut; }
        }

        public double CelsiusIn
        {
            get { return celsiusIn; }
        }




    }
}
