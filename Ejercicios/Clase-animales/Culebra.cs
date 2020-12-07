using System;
public class Culebra: Reptiles // <- Herencia
{
public bool Venenosa { get; set; }

    public Culebra() // <- Polimorfismo
    {
        Venenosa = true;
    }

    public Culebra(bool venenosa) // <- Polimorfismo
    {
        Venenosa = venenosa;
    }
    public void Sonido () // <- Abstraccion
    {
        Console.WriteLine("Sonido: siseo, silbido");
    }

    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Tamano: puede llegar a medir hasta los 1,52 metros de largo");
    }
}