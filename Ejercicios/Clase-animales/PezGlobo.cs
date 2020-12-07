using System;
public class PezGlobo: Peces
{
    public bool Espinas { get; set; }

    public PezGlobo() // <- Polimorfismo
    {
        Espinas = true;
    }

    public PezGlobo(bool espinas) // <- Polimorfismo
    {
        Espinas = espinas;
    }
    public void Inflarse () // <- Abstraccion
    {
        Console.WriteLine("Inflarse: se hincha cuando se siente atacado");
    }

    public void Escamas()
    {
        DescribirEscamas();
        DescribirHabitat();
    }

    private void DescribirEscamas() // <- Encapsulamiento
    {
        Console.WriteLine("Escamas: No posee escamas");
    }
       private void DescribirHabitat() // <- Encapsulamiento
    {
        Console.WriteLine("Habitat: Agua Salada");
    }
}