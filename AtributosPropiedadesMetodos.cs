using System;

namespace AtributosPropiedadesMetodos
{
    public class Sensor
    {
        //Encapsulamiento
        //private int Id;
        private string _Nombre;
        private double _Valor;
        //private float Valor2;

        //Propiedades
        public int Id { get; set; }

        public string Nombre
        {
            set
            {
                this._Nombre = value;
            }
            get
            {
                return this._Nombre;
            }
        }

        public double Valor
        {
            set
            {
                if (value >= 0)
                    this._Valor = value;
                else
                    this._Valor = 1.0;
            }
            get
            {
                return this._Valor;
            }
        }

        //METODOS
        //Getter y Setter (Java)
        //public void setNombre(string Nombre)    //setter
        //{
        //    this.Nombre = Nombre;   //this es un apuntador
        //}

        //public string getNombre()   //getter
        //{
        //    return this.Nombre;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sensor objSensor = new Sensor();

            objSensor.Id = 123;
            objSensor.Nombre = "Presion";
            objSensor.Valor = -9.0;
            objSensor.Valor = 5.0;
            

            //objSensor.setNombre("Temperatura");
            //Console.WriteLine("Nombre: {0}", strAux);
            Console.WriteLine("Id: {0}", objSensor.Id);
            Console.WriteLine("Nombre: {0}", objSensor.Nombre);
            Console.WriteLine("Valor: {0}", objSensor.Valor);

        }
    }
}
