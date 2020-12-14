using System;
public class EstudiantesMat3
{
    public int CodigoMat3 { get; set; }
    public string NombreMat3 { get; set; }
    public string CorreoMat3 { get; set; }

    public EstudiantesMat3(int codigo, string nombre, string correo)
    {
        CodigoMat3 = codigo;
        NombreMat3 = nombre;
        CorreoMat3 = correo;
        
    }
}