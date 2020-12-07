using System;
public class Perro: Mamifero // <- Herencia
{
    public bool EsDomestico { get; set; }
    
    public Perro() // <- Polimorfismo
    {
        EsDomestico = false;
    }
    public Perro(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Ladrar() // <- Abstraccion
    {
        Console.WriteLine("Ladrido: Gua gua gua");
    }

    public void Tamano()
    {
        DescribirTamano();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Tamaño: Es un perro pequeño");
    }

}