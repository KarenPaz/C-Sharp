using System;
public class EstudiantesMat1
{
    public int CodigoMat1 { get; set; }
    public string NombreMat1 { get; set; }
    public string CorreoMat1 { get; set; }

    public EstudiantesMat1(int codigo, string nombre, string correo)
    {
        CodigoMat1 = codigo;
        NombreMat1 = nombre;
        CorreoMat1 = correo;
        
    }

}