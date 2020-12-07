using System;
public class Aguila: Aves
{
    public bool Peligrodeextinsion { get; set; }

    public Aguila() // <- Polimorfismo
    {
        Peligrodeextinsion = true;
    }

    public Aguila(bool peligrodeextinsion) // <- Polimorfismo
    {
        Peligrodeextinsion = peligrodeextinsion;
    }
    public void VolarAlto()  // <- Abstraccion
    {
        Console.WriteLine("Altura: Vuelo incluso superior a los 7.000 metros sobre el nivel del mar");

    }
        public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Tamaño: Hembra 2,3 m. Macho 1,8 m.");
    }
}