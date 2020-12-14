using System;
public class EstudiantesMat2
{
    public int CodigoMat2 { get; set; }
    public string NombreMat2 { get; set; }
    public string CorreoMat2 { get; set; }

    public EstudiantesMat2(int codigo, string nombre, string correo)
    {
        CodigoMat2 = codigo;
        NombreMat2 = nombre;
        CorreoMat2 = correo;
        
    }
}