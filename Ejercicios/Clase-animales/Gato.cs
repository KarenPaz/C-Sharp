using System;
public class Gato: Mamifero  // <- Herencia
{
    public string Pelaje { get; set; }

public Gato() // <- Polimorfismo
{
    Pelaje = "Sin Pelaje";
}

 public void Maullar() // <- Abstraccion
 {
    Console.WriteLine("Maullido: Miau miau miau");
 }
    
 public void Tamano()
 {
    Describirtamano();
 }

 private void Describirtamano() // <- Encapsulamiento
 {
    Console.WriteLine("Tamaño: medio");
 }
}