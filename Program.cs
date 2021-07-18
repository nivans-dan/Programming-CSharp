using System;

namespace MiembrosEstaticos
{
    public class Sensor
    {
        public static int IDGen { get; set; } = 5;
        public int ID { get; set; }
        public double Valor { get; set; }

        public Sensor()
        {
            this.ID = IDGen++;
        }
        public double LeerValor()
        {
            return this.Valor;
        }
        public void ReportaIDGen()
        {
            Console.WriteLine("IDGen = {0}", Sensor.IDGen);
        }
    }//Sensor
    class Program
    {
        static void Main(string[] args)
        {
            Sensor objSensor = new Sensor();
            objSensor.ReportaIDGen();

            Sensor objSensor2 = new Sensor();
            objSensor.ReportaIDGen();

            Sensor objSensor3 = new Sensor();
            objSensor.ReportaIDGen();


            //double dblValor = objSensor.LeerValor();

            Sensor.IDGen = 10;
        }
    }
}
