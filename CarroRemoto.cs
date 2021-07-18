using System;

namespace ProyectoPolimorfInterf
{
    public interface Movimiento
    {
        int Tamaño { get; set; }
        int DistanciaO { get; set; }
        int DistanciaV { get; set; }
        string Orientacion { get; set; }
        void Movimiento(char mov, int o, int v, int t);
    }
    class CarroRobot
    {
        public string Entrada;
        public string Salida;
        public bool Encendido;

        public void Encender()
        {
            this.Encendido = true;
        }
        public void Apagar()
        {
            this.Encendido = false;
        }
    }

    class PuenteH : CarroRobot
    {
        public int Senal;
    }

    class ServoMotor : PuenteH, Movimiento
    {
        public int Tamaño { get; set; }
        public int DistanciaO { get; set; }
        public int DistanciaV { get; set; }
        public string Orientacion { get; set; }

        public void Movimiento(char mov, int o, int v, int t)
        {
            do
            {
                if (mov == 'a')
                {
                    Console.WriteLine("El Carro Robot se mueve a la izquierda");
                    o--;
                }
                if (mov == 's')
                {
                    Console.WriteLine("El Carro Robot se mueve atras");
                    v--;
                }
                if (mov == 'd')
                {
                    Console.WriteLine("El Carro Robot se mueve a la derecha");
                    o++;
                }
                if (mov == 'w')
                {
                    Console.WriteLine("El Carro Robot se mueve adelante");
                    v++;
                }
            } while (o <= t && o >= -t && v <= t && v >= -t);
        }
    }
}

        public class Sensor
        {
            public string ConexionUS;
            public string ConexionIR;
        }

        class SensorUltraSonico : Sensor
        {
            public string Orientacion;
            public decimal Distancia;
        }

        public class SensorInfraRojo : Sensor
        {
            public string SenalIR;
            public bool Conexion;
        }
    class Program
    {
        static void Main(string[] args)
        {
            
            Char mov = Console.ReadLine();
        }
    }
}
