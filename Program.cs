using System;

namespace ConstructoresRepaso
{
    class Concesionario
    {
        public int Llantas { get; set; }
        public string Modelo { get; set; }
        public double Tamaño { get; set; }
        public char Status { get; set; }
        public Concesionario()
        {
            this.Llantas = +1;
        }
        public Concesionario(double Tamaño , string Modelo)
        {
            this.Modelo = Modelo;
            this.Tamaño = Tamaño;
        }
        public Concesionario(int Llantas, string Modelo, double Tamaño, char Status)
        {
            this.Llantas = Llantas;
            this.Modelo = Modelo;
            this.Tamaño = Tamaño;
            this.Status = Status;
        }

        public void Repuesto()
        {
            this.Llantas++;
        }

        public bool Inventario(Concesionario objCoche)
        {
            if ((this.Modelo == objCoche.Modelo) &&
                (this.Tamaño == objCoche.Tamaño))
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Concesionario objCoche = new Concesionario(4, "Mazda 3", 4.46, 'A');
            Concesionario objCoche2 = new Concesionario(4, "Audi A1", 4.06, 'B');
            Concesionario objCoche3;

            //objCoche.Llantas = 4;
            //objCoche.Modelo = "Mazda 3";
            //objCoche.Tamaño = 4.46;
            //objCoche.Status = 'A';

            //objCoche2.Llantas = 4;
            //objCoche2.Modelo = "Audi A1";
            //objCoche2.Tamaño = 4.06;
            //objCoche2.Status = 'B';

            objCoche3 = objCoche;

            if (objCoche.Modelo == objCoche3.Modelo)
                Console.WriteLine("Se tienen modelos Mazda 3 disponibles");
            else
                Console.WriteLine("Sólo se tiene un modelo Mazda 3 disponible");


            if (objCoche2.Status == 'B')
                Console.WriteLine("El modelo Audi A1 no se encuentra disponible por el momento, STATUS B");
            else
                Console.WriteLine("El modelo Audi A1 se encuentra disponible por el momento");

            bool bolInventario;

            bolInventario = objCoche.Inventario(objCoche);
            if (bolInventario == true)
                Console.WriteLine("Se tiene 2 modelos Mazda 3 disponibles");
            else
                Console.WriteLine("No se tienen modelos Mazda 3 disponibles");
            
            objCoche.Repuesto();
            objCoche2.Repuesto();
            objCoche3.Repuesto();
        }
    }
}