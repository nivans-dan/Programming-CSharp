using System;
using System.Collections.Generic;

namespace Listas
{
    class Fase
    {
        public string Tipo { get; set; }
        public Fase(string Tipo)
        {
            this.Tipo = Tipo;
        }
    }

    class Motor
    {
        public List<Fase> Fases { get; set; } = new List<Fase>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Motor ObjMot = new Motor();
            Fase fAdmision = new Fase("Admision");
            Fase fCompresion = new Fase("Compresion");

            List<Fase> lstFases = new List<Fase>();

            lstFases.Add(fAdmision);
            lstFases.Add(fCompresion);
            lstFases.Add(new Fase("Explosion"));
            lstFases.Add(new Fase("Escape"));

            Console.WriteLine("Prueba de motor. Ejecutando fases motor ciclo Otto...");

            foreach (Fase s in lstFases)
            {
                Console.WriteLine("Fase: {0}", s.Tipo);
            }

            lstFases.Remove(fCompresion);
            Console.WriteLine("-------------------");

            Console.WriteLine("Segunda prueba de motor. Ejecutando ultimas fases motor ciclo Otto...");

            lstFases.RemoveAt(2);
            Fase s1 = lstFases.Find(x => x.Tipo == "Explosion");

            foreach (Fase s in lstFases)
            {
                Console.WriteLine("Fase: {0}", s.Tipo);
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Pruebas finalizadas, cierre correcto");
        }
    }
}