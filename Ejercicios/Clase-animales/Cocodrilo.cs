using System;
public class Cocodrilo: Reptiles // <- Herencia
{
    public string Piel { get; set; }
    public Cocodrilo() // <- Polimorfismo
    {
        Piel = "Esta cubierta por escamas compuestas de queratina";
    }

    public void Velocidad()  // <- Abstraccion
    {
        Console.WriteLine("Velocidad: En tierra su velocidad máxima es de entre 2 y 4 km/h");
    }
        public void Temperatura()
    {
        DescribirTemperatura();
    }

    private void DescribirTemperatura() // <- Encapsulamiento
    {
        Console.WriteLine("Temperatura: su temperatura corporal no es controlada por mecanismos internos del organismo sino por su conducta");
    }
}