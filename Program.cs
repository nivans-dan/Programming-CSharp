using System;
using System.Globalization;

namespace SobreCargaMetodos
{
    class Sensor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        private double ValorMin { get; set; } = 0;
        private double ValorMax { get; set; } = 40;

        //Firma de un metodo: nombre del metodo, y #'s y tipo de dato de los parametros en orden secuencial
        public void Incrementa()
        {
            this.Valor++;
        }
        public void Incrementa(int intIncremento)
        {
            if ((this.Valor + intIncremento) < this.ValorMax)
                this.Valor += intIncremento;
           // else
           //     this.Valor = this.ValorMax;
        }
        public void Incrementa(double dblValor)
        {
            this.Valor += dblValor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sensor objSensor = new Sensor();

            Console.Write("Proporciona el Id:");
            objSensor.Id = Int32.Parse(Console.ReadLine()); //convertir cadena en entero
            Console.Write("Proporciona el Nombre:");
            objSensor.Nombre = Console.ReadLine();
            Console.Write("Proporciona el Valor:");
            objSensor.Valor = Double.Parse(Console.ReadLine());

            Console.WriteLine("{0} - {1} - {2}", objSensor.Id, objSensor.Nombre, objSensor.Valor);

            objSensor.Incrementa();
            Console.WriteLine("1) Valor: {0}", objSensor.Valor);
            objSensor.Incrementa(5);
            Console.WriteLine("2) Valor: {0}", objSensor.Valor);
            objSensor.Incrementa(7.75);
            Console.WriteLine("3) Valor: {0}", objSensor.Valor);
        }
    }
}
