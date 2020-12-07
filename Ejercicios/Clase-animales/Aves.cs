using System;

public abstract class Aves: Animal
{
    public string Colorplumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Método: Volar");
    }
}