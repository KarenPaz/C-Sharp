public class Alumno
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }

    public Alumno(int id, string primernombre, string segundonombre)
    {
        Id =id;
        PrimerNombre = primernombre;
        SegundoNombre = segundonombre;
    }
    
    public string nombreCompleto(){
        return PrimerNombre + " " + SegundoNombre;
    }
}