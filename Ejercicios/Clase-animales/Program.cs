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

            PezGlobo pg = new PezGlobo();
            Console.WriteLine("Pez Globo: Tetrodontidos");
            pg.Nombre = "Gluglu";
            pg.Aletas = "Pectoral y dorsal";
            Console.WriteLine("Nombre: "+ pg.Nombre);
            Console.WriteLine("Aletas: " + pg.Aletas);
            Console.WriteLine("Espinas: "+ pg.Espinasexternas);
            pg.Comer();
            pg.Nadar();
            pg.Inflarse();
            pg.EscamasyHabitat();
            Console.WriteLine();

            Console.WriteLine("***Aves***");
            Aguila a = new Aguila();
            Console.WriteLine("Aguila: Calva");
            a.Nombre = "Kus";
            a.Colorplumaje = "marron y blanco";
            Console.WriteLine("Nombre: "+ a.Nombre);
            Console.WriteLine("Color plumas: " + a.Colorplumaje);
            Console.WriteLine("Peligro de extinsion: "+ a.Peligrodeextinsion);
            a.Comer();
            a.Volar();
            a.VolarAlto();
            a.Tamano();
            Console.WriteLine();

            Loro l = new Loro();
            Console.WriteLine("Loro");
            l.Nombre = "Bender";
            l.Colorplumaje = "Verde fuerte";
            Console.WriteLine("Nombre: "+ l.Nombre);
            Console.WriteLine("Color plumas: " + l.Colorplumaje);
            Console.WriteLine("Domestico: "+ l.EsDomestico);
            l.Comer();
            l.Volar();
            l.Hablar();
            l.Alimentacion();
            Console.WriteLine();

            Console.WriteLine("***Reptiles***");
            Cocodrilo c = new Cocodrilo();
            Console.WriteLine("Cocodrilo");
            c.Nombre = "Bendi";
            c.Patas = true;
            Console.WriteLine("Nombre: "+ c.Nombre);
            Console.WriteLine("Patas: " + c.Patas);
            Console.WriteLine("Piel: "+ c.Piel);
            c.Comer();
            c.Arrastrar();
            c.Velocidad();
            c.Temperatura();
            Console.WriteLine();

            Culebra s = new Culebra();
            Console.WriteLine("Serpiente: cascabel");
            s.Nombre = "Letal";
            s.Patas = false;
            Console.WriteLine("Nombre: "+ s.Nombre);
            Console.WriteLine("Patas: " + s.Patas);
            Console.WriteLine("Venenosa: "+ s.Venenosa);
            s.Comer();
            s.Arrastrar();
            s.Sonido();
            s.Tamano();
            Console.WriteLine();
        }
    }
}
