using System;
public class Loro: Aves
{
    public bool EsDomestico { get; set; }
    
    public Loro() // <- Polimorfismo
    {
        EsDomestico = true;
    }
    public Loro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Hablar() // <- Abstraccion
    {
        Console.WriteLine("Hablar: aprenden con facilidad a Hablar");
    }

    public void Alimentacion()
    {
        DescribirAlimentacion();
    }

    private void DescribirAlimentacion() // <- Encapsulamiento
    {
        Console.WriteLine("Alimentación:  semillas, raíces, tubérculos y frutas");
    }
}