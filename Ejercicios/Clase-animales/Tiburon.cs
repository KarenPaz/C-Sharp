using System;
public class Tiburon: Peces
{
    public bool Depredador { get; set; }

    public Tiburon() // <- Polimorfismo
    {
        Depredador = true;
    }

    public Tiburon(bool depredador) // <- Polimorfismo
    {
        Depredador = depredador;
    }
    public void Color () // <- Abstraccion
    {
        Console.WriteLine("Color: gris con rayas y puntos blancos");
    }

    public void Alimentacion()
    {
        DescribirAlimentacion();
    }

    private void DescribirAlimentacion() // <- Encapsulamiento
    {
        Console.WriteLine("Alimentación: se alimentan de plancton");
    }
}