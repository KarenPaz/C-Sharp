using System;

public abstract class Reptiles: Animal
{
    public int PielResistente { get; set; }

    public void Arrastrar()
    {
        Console.WriteLine("Reptan o arrastran");
    }
}