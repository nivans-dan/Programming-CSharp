using System;
using System.Runtime.CompilerServices;

namespace Excepciones
{
    class Microcontrolador
    {
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Valor { get; set; }
        public Microcontrolador() { }
        public Microcontrolador(int Entradas, int Salidas, int Valor)
        {
            this.Entradas = Entradas;
            this.Salidas = Salidas;
            this.Valor = Valor;
        }
        public virtual void EnviarValor()
        {
            Console.WriteLine("Me dirijo a un microcontrolador en especifico. El valor del microcontrolador es de: {0}", this.Valor);
        }
        public const double ValMin = 20.0;
        public const double ValMax = 90.0;
        public const string Tipo = "Microcontrolador";
        public enum TMicro { Arduino, Raspberry, Leonardo };
        public enum Rango : long { Max = 1326712332, Min = 255 };

        public TMicro Operacion { get; set; }
        public bool ComparaMax(double Val)
        {
            if (Val > ValMax)
                return true;

            else
                return false;
        }
        public bool ComparaMin(double Val)
        {
            if (Val < ValMin)
                return true;
            else
                return false;
        }
        public void ImpMicro()
        {
            TMicro tm;
            
            tm = TMicro.Leonardo;
            int itm = (int)tm;

            long l = 49999999999L;

            Console.WriteLine(TMicro.Leonardo);
            Console.WriteLine((int)TMicro.Leonardo);
        }

    }

    class Arduino : Microcontrolador
    {
        public string tipoEntrada { get; set; }
        public string tipoSalida { get; set; }
        public Arduino() { }
        public Arduino(int Entradas, int Salidas, int Valor, string tipoEntrada, string tipoSalida) : base(Entradas, Salidas, Valor)
        {
            this.tipoEntrada = tipoEntrada;
            this.tipoSalida = tipoSalida;
        }
        public override void EnviarValor()
        {
            Console.WriteLine("El valor en Arduino es de : {0}", this.Valor);
        }
    }

    class Raspberry : Microcontrolador
    {
        public string tipoValor { get; set; }
        public Raspberry() { }
        public Raspberry(int Entradas, int Salidas, int Valor, string tipoValor) : base(Entradas, Salidas, Valor)
        {
            this.tipoValor = tipoValor;
        }
        public override void EnviarValor()
        {
            Console.WriteLine("El valor en Raspberry es de : {0}", this.Valor);
        }
    }

    class ArduinoLeonardo : Arduino
    {
        public ArduinoLeonardo() { }
        public ArduinoLeonardo(int Entradas, int Salidas, int Valor, string tipoEntrada) : base(Entradas, Salidas, Valor, tipoEntrada, tipoEntrada)
        {

        }
        public override void EnviarValor()
        {
            Console.WriteLine("El valor en ArduinoLeonardo es de : {0}", this.Valor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Microcontrolador objMic = new Microcontrolador(2, 3, 100);
            Arduino objArduino = new Arduino(1, 3, 8, "A0", "1N");
            Raspberry objRasp = new Raspberry(4, 5, 12, "GPIO23");
            ArduinoLeonardo objArdLeo = new ArduinoLeonardo(3, 3, 4, "A1");

            Microcontrolador objmic = objArduino;
            //objmic.Salidas = 15;

            try
            {
                Console.WriteLine("Dame valor para salidas (entero)");
                objmic.Salidas = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ingresa un entero\n");
            }

            try
            {
                Console.WriteLine("Dame valor para entradas (entero)");
                objmic.Entradas = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ingresa un entero\n");
            }

            ((Arduino)objmic).Valor = 19;

            Microcontrolador[] arrmic = new Microcontrolador[4];
            arrmic[0] = objMic;
            arrmic[1] = objArduino;
            arrmic[2] = objRasp;
            arrmic[3] = objArdLeo;

            foreach (Microcontrolador obj in arrmic)
            {
                obj.EnviarValor();
            }


            objMic.EnviarValor();
            objArduino.EnviarValor();
            objRasp.EnviarValor();
            objArdLeo.EnviarValor();

            Microcontrolador v = new Microcontrolador();


            bool bolResult = v.ComparaMax(100);
            if (bolResult == true)
                Console.Write("El Microcontrolador tiene un valor Maximo\n");
            bool bolResult2 = v.ComparaMin(10);
            if (bolResult2 == true)
                Console.Write("El Microcontrolador tiene un valor Minimo\n");

            Console.Write("Tipo de Microcontrolador\n");
            v.ImpMicro();
            v.Operacion = Microcontrolador.TMicro.Leonardo;

            int a;
            string s = "Raspberry";
            switch (s)
            {
                case "Arduino":
                    a = 10;
                    Console.Write("Arduino tiene un valor de {0}\n", a);
                    break;
                case "Raspberry":
                    a = 20;
                    Console.Write("Raspberry tiene un valor de {0}\n", a);
                    break;
                case "Leonardo":
                    a = 30;
                    Console.Write("Leonardo tiene un valor de {0}\n", a);
                    break;
                default:
                    a = 0;
                    break;
            }
        }
    }
}