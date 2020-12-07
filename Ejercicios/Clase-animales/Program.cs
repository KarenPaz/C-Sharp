using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Animales********");
            Console.WriteLine();
            
            Console.WriteLine("***Mamiferos***");
            Perro p = new Perro();
            Console.WriteLine("Perro: Chihuahua");
            p.Nombre = "Firulais";
            p.Patas = 4;
            Console.WriteLine("Nombre: "+ p.Nombre);
            Console.WriteLine("Patas: " + p.Patas);
            p.EsDomestico = true;
            Console.WriteLine("Domestico: "+ p.EsDomestico);
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();
            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("Gato: Persa");
            g.Nombre = "Garfield";
            g.Patas = 4;
            Console.WriteLine("Nombre: "+ g.Nombre);
            Console.WriteLine("Patas: "+ g.Patas);
            g.Pelaje = "Peludo";
            Console.WriteLine("Pelaje: "+ g.Pelaje);
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.Tamano();
            Console.WriteLine();
   
            Console.WriteLine("***Peces***");
            Tiburon t = new Tiburon();
            Console.WriteLine("Tiburón: ballena");
            t.Nombre = "Rhincodon";
            t.Aletas = "Pectoral y dorsal";
            Console.WriteLine("Nombre: "+ t.Nombre);
            Console.WriteLine("Aletas: " + t.Aletas);
            t.Depredador = false;
            Console.WriteLine("Depredador: "+ t.Depredador);
            t.Comer();
            t.Nadar();
            t.Color();
            t.Alimentacion();
            Console.WriteLine();

        }
    }
}
