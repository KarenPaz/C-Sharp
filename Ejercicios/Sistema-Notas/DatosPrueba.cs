using System;
using System.Collections.Generic;
public class DatosPrueba
{
    public List<Materias> ListaMaterias { get; set; }
    public List<EstudiantesMat1> ListaEstudiantesMat1 { get; set; }
    public List<EstudiantesMat2> ListaEstudiantesMat2 { get; set; }
    public List<EstudiantesMat3> ListaEstudiantesMat3 { get; set; }
    public List<EstudiantesMat4> ListaEstudiantesMat4 { get; set; }
    //public List<Calificaciones> ListaNotas { get; set; }

    public DatosPrueba()
    {
        ListaMaterias = new List<Materias>();
        cargarMaterias();
        ListaEstudiantesMat1 = new List<EstudiantesMat1>();
        cargarEstudiantesMat1();
        ListaEstudiantesMat2 = new List<EstudiantesMat2>();
        cargarEstudiantesMat2();
        ListaEstudiantesMat3 = new List<EstudiantesMat3>();
        cargarEstudiantesMat3();
        ListaEstudiantesMat4 = new List<EstudiantesMat4>();
        cargarEstudiantesMat4();
    //    ListaNotas = new List<Calificaciones>();
     //   cargarNotas();
    }

    private void cargarMaterias()
    {
        Materias m1 = new Materias (1, "Lenguaje de programación 1");
        ListaMaterias.Add(m1);
        Materias m2 = new Materias (2, "Lenguaje de programación 2");
        ListaMaterias.Add(m2);
        Materias m3 = new Materias (3, "Sistemas Operativos 1");
        ListaMaterias.Add(m3);
        Materias m4 = new Materias (4, "Taller 1");
        ListaMaterias.Add(m4);
    }
    private void cargarEstudiantesMat1()
    {
        EstudiantesMat1 e11 = new EstudiantesMat1 (5, "Jorge Villanueva", "jvillanueva@unah.hn");
        ListaEstudiantesMat1.Add(e11);
        EstudiantesMat1 e12 = new EstudiantesMat1 (6, "Karen Paz       ", "kpaz@unah.hn");
        ListaEstudiantesMat1.Add(e12);
        EstudiantesMat1 e13 = new EstudiantesMat1 (7, "Yesica Amaya    ", "yamaya@unah.hn");
        ListaEstudiantesMat1.Add(e13);
    }
    private void cargarEstudiantesMat2()
    {
        EstudiantesMat2 e21 = new EstudiantesMat2 (8, "Andrea Bardales ", "abardales@unah.hn");
        ListaEstudiantesMat2.Add(e21);
        EstudiantesMat2 e22 = new EstudiantesMat2 (9, "Naya Morgado    ", "Nmorgado@unah.hn");
        ListaEstudiantesMat2.Add(e22);
        EstudiantesMat2 e23 = new EstudiantesMat2 (10, "Edgardo Torres ", "etorres@unah.hn");
        ListaEstudiantesMat2.Add(e23);
    }
    private void cargarEstudiantesMat3()
    {
        EstudiantesMat3 e31 = new EstudiantesMat3 (11, "Carlos Garcia  ", "Cgarcia@unah.hn");
        ListaEstudiantesMat3.Add(e31);
        EstudiantesMat3 e32 = new EstudiantesMat3 (12, "Karla Jauregui ", "kjauregui@unah.hn");
        ListaEstudiantesMat3.Add(e32);
        EstudiantesMat3 e33 = new EstudiantesMat3 (13, "Maria Martinez ", "Mmartinez@unah.hn");
        ListaEstudiantesMat3.Add(e33);
    }
    private void cargarEstudiantesMat4()
    {
        EstudiantesMat4 e41 = new EstudiantesMat4 (10, "Keana Bardales ", "abardales@unah.hn");
        ListaEstudiantesMat4.Add(e41);
        EstudiantesMat4 e42 = new EstudiantesMat4 (11, "Camila Morgado ", "cmorgado@unah.hn");
        ListaEstudiantesMat4.Add(e42);
        EstudiantesMat4 e43 = new EstudiantesMat4 (12, "Edgardo Torres ", "etorres@unah.hn");
        ListaEstudiantesMat4.Add(e43);
    }
    public void ListarMaterias()
    {
        Console.Clear();
        Console.WriteLine("Lista de Materias");
        Console.WriteLine("=================");
        Console.WriteLine("");

        foreach (var materia in ListaMaterias)
        {
            Console.WriteLine(materia.CodMateria + " | " + materia.NomMateria);
        }
        Console.ReadLine();
    }
    public void ListarEstudiantes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes por materia");
        Console.WriteLine("================================");
        Console.WriteLine("");

        foreach (var materia in ListaMaterias)
        {
            Console.WriteLine(materia.CodMateria + " | " + materia.NomMateria);
        }  
    }
    public void ListarEstudiantesMat1()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes clase de Lenguaje de programación 1");
        Console.WriteLine("========================================================");
        Console.WriteLine("");
        Console.WriteLine(" Cod. |     Nombre       |       correo    ");
        foreach (var estudiantesmat1 in ListaEstudiantesMat1)
        {
            Console.WriteLine(estudiantesmat1.CodigoMat1 + "     | " + estudiantesmat1.NombreMat1 + " | " + estudiantesmat1.CorreoMat1);
        }
        Console.ReadLine();
    }
    public void ListarEstudiantesMat2()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes clase de Lenguaje de programación 2");
        Console.WriteLine("========================================================");
        Console.WriteLine("");
        Console.WriteLine(" Cod. |    Nombre        |       correo    ");
        foreach (var estudiantesmat2 in ListaEstudiantesMat2)
        {
            Console.WriteLine(estudiantesmat2.CodigoMat2 + "     | " + estudiantesmat2.NombreMat2 +  " | " + estudiantesmat2.CorreoMat2);
        }
        Console.ReadLine();
    }
    public void ListarEstudiantesMat3()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes clase de Sistemas operativos 1");
        Console.WriteLine("===================================================");
        Console.WriteLine("");
        Console.WriteLine(" Cod.  |     Nombre      |       correo    ");

        foreach (var estudiantesmat3 in ListaEstudiantesMat3)
        {
            Console.WriteLine(estudiantesmat3.CodigoMat3 + "     | " + estudiantesmat3.NombreMat3 +  " | " + estudiantesmat3.CorreoMat3);
        }
        Console.ReadLine();
    }
    public void ListarEstudiantesMat4()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes clase de Taller 1");
        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine(" Cod.  |      Nombre     |       correo    ");
        foreach (var estudiantesmat4 in ListaEstudiantesMat4)
        {
            Console.WriteLine(estudiantesmat4.CodigoMat4 + "     | " + estudiantesmat4.NombreMat4 +  " | " + estudiantesmat4.CorreoMat4);
        }
        Console.ReadLine();
    }
    public void ingresaNotasEstMat1()
    {
        Console.Clear();
        Console.WriteLine("Ingreso de calificaciones a estudiantes");
        Console.WriteLine("=======================================");
        Console.WriteLine("");
        
       while (true)
       {
            Console.WriteLine("Ingrese el codigo de estudiante: ");
            string codiestumat1 = Console.ReadLine();
            EstudiantesMat1 estudiante1 = ListaEstudiantesMat1.Find(e => e.CodigoMat1.ToString() == codiestumat1);        
            if (estudiante1 == null)
            {
                Console.WriteLine("Estudiante no encontrado");
                Console.ReadLine();
                return;
            }else {
                Console.WriteLine("Estudiante: " + estudiante1.NombreMat1);
                Console.WriteLine("");
                AgregarNotas();
                Console.Write("Desea agregar notas a otro estudiante s/n: ");
                string aceptar = Console.ReadLine();
                if (aceptar.ToLower() == "n"){
                break;
                }

            } 
        }
    }
    public void ingresaNotasEstMat2()
    {
        Console.Clear();
        Console.WriteLine("Ingreso de calificaciones a estudiantes");
        Console.WriteLine("=======================================");
        Console.WriteLine("");
       while (true)
       {
            Console.WriteLine("Ingrese el codigo de estudiante: ");
            string codiestumat2 = Console.ReadLine();
            EstudiantesMat2 estudiante2 = ListaEstudiantesMat2.Find(e => e.CodigoMat2.ToString() == codiestumat2);        
            if (estudiante2 == null)
            {
                Console.WriteLine("Estudiante no encontrado");
                Console.ReadLine();
                return;
            }else {
                Console.WriteLine("Estudiante: " + estudiante2.NombreMat2);
                Console.WriteLine("");
                AgregarNotas();
            } 
        }
    }
    public void ingresaNotasEstMat3()
    {
        Console.Clear();
        Console.WriteLine("Ingreso de calificaciones a estudiantes");
        Console.WriteLine("=======================================");
        Console.WriteLine("");

       while (true)
       {
            Console.WriteLine("Ingrese el codigo de estudiante: ");
            string codiestumat3 = Console.ReadLine();
            EstudiantesMat3 estudiante3 = ListaEstudiantesMat3.Find(e => e.CodigoMat3.ToString() == codiestumat3);        
            if (estudiante3 == null)
            {
                Console.WriteLine("Estudiante no encontrado");
                Console.ReadLine();
                return;
            }else {
                Console.WriteLine("Estudiante: " + estudiante3.NombreMat3);
                Console.WriteLine("");
                AgregarNotas();
            } 
        }
    }
    public void ingresaNotasEstMat4()
    {
        Console.Clear();
        Console.WriteLine("Ingreso de calificaciones a estudiantes");
        Console.WriteLine("=======================================");
        Console.WriteLine("");
       while (true)
       {
            Console.WriteLine("Ingrese el codigo de estudiante: ");
            string codiestumat4 = Console.ReadLine();
            EstudiantesMat4 estudiante4 = ListaEstudiantesMat4.Find(e => e.CodigoMat4.ToString() == codiestumat4);        
            if (estudiante4 == null)
            {
                Console.WriteLine("Estudiante no encontrado");
                Console.ReadLine();
                return;
            }else {
                Console.WriteLine("Estudiante: " + estudiante4.NombreMat4);
                Console.WriteLine("");
                AgregarNotas();
            } 
        }
    }
    public void AgregarNotas()
    {
      while(true)
      {
       Console.Write ("Nota total de foros (maximo 10)   : ");
       string foro = Console.ReadLine();
       if (Int32.Parse(foro)> 10)
       {
           Console.WriteLine("La nota debe ser menor o igual a 10");
           break;
       }
       Console.Write ("Nota total de tareas (maximo 30)  : ");
       string tareas = Console.ReadLine();
       if (Int32.Parse(tareas)> 30)
       {
           Console.WriteLine("La nota debe ser menor o igual a 30");
           break;
       }
       Console.Write ("Nota total de examenes (maximo 60): ");
       string examenes = Console.ReadLine();
       if (Int32.Parse(examenes)> 60)
       {
           Console.WriteLine("La nota debe ser menor o igual a 60");
           break;
       }
       int notafinal= Int32.Parse(foro)+Int32.Parse(tareas)+Int32.Parse(examenes);
       Console.WriteLine ("Nota final :" + notafinal); 
       break;
       }
    } 
}  