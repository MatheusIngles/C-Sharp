using System.Linq;

namespace Exercicio_2
{
    internal class Conversor
    {
        public double Temperatura, media;
        bool C, F, K;
        List<double> TemperaturaList = [];

        public Conversor(double temperatura, bool c, bool f, bool k)
        {
            Temperatura = temperatura;
            C = c;
            F = f;
            K = k;
        }

        public void CpF()
        {
            if (F)
            {
                Console.WriteLine("A temperatura Já esta em Fahrenheit");
            }
            else
            {
                Temperatura = Temperatura * 1.8 + 32;
                C = false;
                F = true;
            }
        }
        public void FpC()
        {
            if (C)
            {
                Console.WriteLine("A temperatura Já esta em Celsius");
            }
            else
            {
                F = false;
                C = true;
                Temperatura = (Temperatura - 32) / 1.8;
            }
        }
        public void CpK()
        {
            if (K)
            {
                Console.WriteLine("A temperatura Já esta em Kelvin");
            }
            else
            {
                C = false;
                K = true;
                Temperatura = Temperatura + 273.15;
            }
        }
        public void KpC()
        {
            if (C) {
                Console.WriteLine("A temperatura Já esta em Celsius");
            }
            else
            {
                K = false;
                C = true;
                Temperatura = Temperatura - 273.15;
            }
        }

        public void FazerMedia(double temperatura)
        {
            TemperaturaList.Add(temperatura);
            media = TemperaturaList.Average();
        }
    }
}
