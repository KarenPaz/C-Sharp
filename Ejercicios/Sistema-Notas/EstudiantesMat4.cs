using System;
public class EstudiantesMat4
{
    public int CodigoMat4 { get; set; }
    public string NombreMat4 { get; set; }
    public string CorreoMat4 { get; set; }

    public EstudiantesMat4(int codigo, string nombre, string correo)
    {
        CodigoMat4 = codigo;
        NombreMat4 = nombre;
        CorreoMat4 = correo;
        
    }
}