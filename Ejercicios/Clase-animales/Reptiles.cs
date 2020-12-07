using System;

public abstract class Reptiles: Animal
{
    public bool Patas{ get; set; }

    public void Arrastrar()
    {
        Console.WriteLine("Método: Reptan o arrastran");
    }
}