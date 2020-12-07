using System;

public abstract class Peces: Animal
{
    public string Aletas { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Método: Nadando");
    }
}