using System;

namespace Sistema_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosPrueba datos = new DatosPrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA INGRESO DE NOTAS, INFORMATICA ADMINISTRATIVA");
                Console.WriteLine("====================================================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Materias");
                Console.WriteLine("2 - Lista de Estudiantes por materia");
                Console.WriteLine("3 - Ingreso de Notas");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                Console.Write ("Ingrese numero de opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarMaterias();
                        break;
                    case "2":
                       string opcion1 = "";
                       datos.ListarEstudiantes();
                       Console.Write("Ingrese codigo de materia: ");
                       opcion1 = Console.ReadLine();
                       switch (opcion1)
                       {
                           case "1":
                              datos.ListarEstudiantesMat1();
                              break;
                           case "2":
                              datos.ListarEstudiantesMat2();
                              break;
                            case "3":
                              datos.ListarEstudiantesMat3();
                              break;
                            case "4":
                              datos.ListarEstudiantesMat4();
                              break;
                            default:
                              break;
                       }    
                        break;
                    case "3":
                        string opcion2 = "";
                        datos.ListarMaterias();
                        Console.Write("Ingre codigo de materia:");
                        opcion2 = Console.ReadLine();
                        switch (opcion2)
                       {
                           case "1":
                              datos.ingresaNotasEstMat1();
                              break;
                           case "2":
                              datos.ingresaNotasEstMat2();
                              break;
                            case "3":
                              datos.ingresaNotasEstMat3();
                              break;
                            case "4":
                              datos.ingresaNotasEstMat4();
                              break;
                            default:
                              break;
                       }    
                        break;
                }
                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
