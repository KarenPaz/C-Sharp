using System;
public class PezGlobo: Peces
{
    public string Garras { get; set; }

    public void VolarAlto()
    {
        Console.WriteLine("20 metros sobre el nivel del mar");
    }
}