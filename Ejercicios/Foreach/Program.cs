using System;
using System.Collections.Generic;


namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Pablo");
            nombres.Add("Camila");
            nombres.Add("Michelle");

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            List<int> numeros = new List<int>();
            numeros.Add(27);
            numeros.Add(03);
            numeros.Add(5);

            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno(1, "Michelle");
            Alumno b = new Alumno(2, "Camila");
            Alumno c = new Alumno(3, "Pablo");

            alumnos.Add(a);
            alumnos.Add(b);
            alumnos.Add(c);

            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno.Nombre);
            }

        }
    }
}
