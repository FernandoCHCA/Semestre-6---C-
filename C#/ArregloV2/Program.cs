using System.Text.RegularExpressions;

namespace ArregloV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de registro de Alumnos
            string[,] ArregloAlumn = new string[100, 2];
            // Inicializar el índice de la matriz
            int indice = 0;
            // Creando lista donde se guardara el arreglo
            List<string> ListaAlumnos = new List<string>();
            // Creando el PATH donde se guardara el txt
            string path = "C:\\Users\\Jose Chavez\\Documents\\FernandoC\\Semestre-6---C-\\C#\\ArregloV2\\ListaAlumnos.txt";
            // Creando Regex para validar
            Regex regexLetras = new Regex("^[a-zA-Z]+$");
            Regex regexNum = new Regex("^[0-9]+$");
            // Menu de opciones a elegir
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido! Escoge la opcion que quieras: \n");
                Console.WriteLine("1. Agregar a un Alumno");
                Console.WriteLine("2. Ver lista de Alumnos hasta el momento");
                Console.WriteLine("3. Guardar los datos de los Alumnos en un archivo txt");
                Console.WriteLine("4. Salir del programa");
                Console.WriteLine("\n*****************************************");
                Console.WriteLine("\nSeleccione una opción: ");
                Console.Write("-> ");

                int selection;
                if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= 4)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("*****************************************");
                            Console.WriteLine("\nEscogiste agregar un Alumno!\n");
                            Console.WriteLine("*****************************************\n");

                            // Se valida que el nombre solo contenga letras
                            bool inputValido = false;
                            while (!inputValido)
                            {
                                Console.WriteLine("Escribe el nombre del Alumno: ");
                                Console.Write("-> ");
                                string NombreAlum = Console.ReadLine();

                                if (regexLetras.IsMatch(NombreAlum))
                                {
                                    inputValido = true;
                                    Console.WriteLine("\nEscribe la matricula del Alumno: ");
                                    Console.Write("-> ");
                                    string MatriculaAlum = Console.ReadLine();
                                    
                                    // FALLO: Si no hace match se sale de la opcion de agregar alumno,
                                    //        deberia dar un mensaje que no es permitido lo que se ingreso y que vuelva a escribir,
                                    //        hasta que de con lo indicado.
                                    if (regexNum.IsMatch(MatriculaAlum))
                                    {
                                        Console.WriteLine("\n*****************************************\n");

                                        // Almacenar el nombre y la matrícula en la matriz
                                        ArregloAlumn[indice, 0] = NombreAlum;
                                        ArregloAlumn[indice, 1] = MatriculaAlum;

                                        // Incrementar el índice de la matriz
                                        indice++;

                                        // Preguntar si desea ingresar otro dato
                                        // FALLO: Solo si es "SI" deja agregar otro alumno
                                        //        pero si se pone cualquier cosa se sale, lo esperado es que
                                        //        solo se salga si se escribe "NO", y cualquier otra cosa que ingrese
                                        //        no le permita salirse y le mande un mensaje de error hasta que escriba
                                        //        lo que se espera.
                                        Console.WriteLine("¿Desea agregar otro Alumno? (SI/NO)");
                                        Console.Write("-> ");
                                        string respuesta = Console.ReadLine();
                                        if (respuesta.ToUpper() == "SI")
                                        {
                                            Console.Clear();
                                            inputValido = false;
                                            Console.WriteLine("\n*****************************************\n");
                                        }
                                        else if (respuesta.ToUpper() == "NO")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nNo es valido! Vuelva a intentar!\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLa matricula ingresada contiene letras o caracteres no permitidos\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEl nombre ingresado contiene numeros o caracteres no permitidos\n");
                                }
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("*****************************************");

                            // Se muestra el arreglo/matriz
                            Console.WriteLine("\n|Alumnos - Matriculas|\n");
                            for (int i = 0; i < indice; i++)
                            {
                                Console.WriteLine(ArregloAlumn[i, 0] + " - " + ArregloAlumn[i, 1]);
                            }
                            Console.WriteLine("\n*****************************************\n");

                            // Preguntar si quiere continuar o no en el programa
                            string SeguirC2 = "";
                            while (SeguirC2 != "SI" && SeguirC2 != "NO")
                            {
                                Console.WriteLine("¿Quíeres seguir continuando con el programa? (SI|NO)");
                                Console.Write("-> ");
                                SeguirC2 = Console.ReadLine().ToUpper();
                                switch (SeguirC2)
                                {
                                    case "SI":
                                        Console.Clear();
                                        break;
                                    case "NO":
                                        return;
                                    default:
                                        Console.WriteLine("\nNo es valido! Vuelva a intentar!\n");
                                        break;
                                }
                            }
                            break;
                        case 3:
                            Console.Clear();

                            // Se borra primero lo que hay en la lista, para evitar duplicados
                            ListaAlumnos.Clear();

                            // Se guarda lo que hay hasta el momento en la lista "ListaAlumnos"
                            ListaAlumnos.Add("|Alumnos - Matriculas|\n");
                            for (int i = 0; i < indice; i++)
                            {
                                ListaAlumnos.Add(ArregloAlumn[i, 0] + " - " + ArregloAlumn[i, 1]);
                            }

                            // Se guarda en el archivo txt los datos que hay actualmente
                            TextWriter tw = new StreamWriter(path);
                            foreach (String s in ListaAlumnos)
                                tw.WriteLine(s);
                                tw.Close();

                            Console.WriteLine("\nPerfecto, se han guardado los datos de los Alumnos satisfactoriamente!\n");

                            // Preguntar si quiere continuar o no en el programa
                            string SeguirC3 = "";
                            while (SeguirC3 != "SI" && SeguirC3 != "NO")
                            {
                                Console.WriteLine("¿Quíeres seguir continuando con el programa? (SI|NO)");
                                Console.Write("-> ");
                                SeguirC3 = Console.ReadLine().ToUpper();
                                switch (SeguirC3)
                                {
                                    case "SI":
                                        Console.Clear();
                                        break;
                                    case "NO":
                                        return;
                                    default:
                                        Console.WriteLine("\nNo es valido! Vuelva a intentar!\n");
                                        break;
                                }
                            }
                            break;
                        case 4:
                            Console.Clear();

                            // Se acaba el programa y se sale
                            Console.WriteLine("\nPerfecto, ya no agregará a ningun alumno. Hasta pronto!\n");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Selección inválida");
                }
            }
        }
    }
}