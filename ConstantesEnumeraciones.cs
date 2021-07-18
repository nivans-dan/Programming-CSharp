using System;

namespace ConstantesEnumeraciones
{
    class  Termopar
    {
        public const double TempMin = -40.0;
        public const double TempMax = 1500.0;
        public const string Mensaje = "Hola";

        public enum DiaSem { Lun = 1, Mar, Mie, Jue, Vie, Sab, Dom };
        public enum Rango : long { Max = 1254512154L, Min = 255L};

        public enum Puertos
        {
            Voltaje = 0x01,
            Motor = 0x02,
            Camara = 0x04,
            Ultrasonico = 0x08
        }

        public bool ComparaMax(double Temp)
        {
            if (Temp > TempMax)
                return true;
            else
                return false;
        }

        public DiaSem InicioOperacion { get; set; }

        public void ImprimeDia()
        {
            DiaSem ds;

            ds = DiaSem.Mie;
            int ids = (int)ds;

            long l = 4999999999L;

            Console.WriteLine(DiaSem.Dom);
            Console.WriteLine((int)DiaSem.Dom); //Cast

            //TempMin = -100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Termopar t = new Termopar();

            bool bolResult = t.ComparaMax(1750);

            t.ImprimeDia();
            t.InicioOperacion = Termopar.DiaSem.Vie;
        }
    }
}
