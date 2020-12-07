using System;
public class PezGlobo: Peces
{
    public bool Espinasexternas { get; set; }

    public PezGlobo() // <- Polimorfismo
    {
        Espinasexternas = true;
    }

    public PezGlobo(bool espinasexternas) // <- Polimorfismo
    {
        Espinasexternas = espinasexternas;
    }
    public void Inflarse () // <- Abstraccion
    {
        Console.WriteLine("Inflarse: se hincha cuando se siente atacado");
    }

    public void EscamasyHabitat()
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