using System;
public class Materias

{
   public int CodMateria { get; set; } 
   public string NomMateria { get; set; }

   public Materias(int codmateria, string nommateria)
   {
       CodMateria = codmateria;
       NomMateria = nommateria;
   }

}