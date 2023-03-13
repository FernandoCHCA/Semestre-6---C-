using System.IO;
using System.Threading;

namespace Evidencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Resp = 1;

            // Creando lista donde se guardará las respuestas
            List<string> ListaResultado = new List<string>();
            // Declaracion de indices de operaciones
            int numDivision = 0;
            int numAreaRombo = 0;
            int numRaizElevada = 0;
            int numDivisas = 0;

            // Creando el PATH donde se guardara el txt
            string path = "C:\\Users\\Jose Chavez\\Documents\\FernandoC\\Semestre-6---C-\\C#\\Evidencia1\\Evidencia1\\ResultadosOP.txt";
            Console.WriteLine("***********************************************************************\n");
            Console.WriteLine("Ingrese su nombre: ");
            Console.Write("-> ");
            string usuario = Console.ReadLine();
            Console.WriteLine("\nBienvenido " + usuario + " al programa! Esperemos y te la pases bien!");
            Console.WriteLine("\n***********************************************************************");
            Thread.Sleep(1500);

            do
            {
                Console.Clear();
                Console.WriteLine("******************************************\n");
                Console.WriteLine("Bienvenido! Escoge la opcion que quieras: \n");
                Console.WriteLine("1- DIVISION ");
                Console.WriteLine("2- AREA DE ROMBO ");
                Console.WriteLine("3- RAIZ ELEVADA ");
                Console.WriteLine("4- DIVISAS");
                Console.WriteLine("5- SALIR DEL PROGRAMA");
                Console.WriteLine("\n******************************************");
                Console.WriteLine("\nSeleccione una opción: ");
                Console.Write("-> ");
                string opcionMenuSTR = Console.ReadLine();
                int opcionMenuINT = Convert.ToInt32(opcionMenuSTR);
                switch (opcionMenuINT)
                {
                    case 1:
                        Thread.Sleep(500);
                        numDivision++;
                        Console.Clear();

                        Console.WriteLine("*****************************************");
                        Console.WriteLine("\nHas escodigo la opcion -> DIVISION!\n");
                        Console.WriteLine("*****************************************\n");

                        Console.WriteLine("Ingrese un primer numero:");
                        Console.Write("-> ");
                        string primerNumSTR = Console.ReadLine();
                        int primerNumINT = Convert.ToInt32(primerNumSTR);
                        Console.WriteLine("\n------------------------\n");
                        Console.WriteLine("Ingrese un segundo numero:");
                        Console.Write("-> ");
                        string segundoNumSTR = Console.ReadLine();
                        int segundoNumINT = Convert.ToInt32(segundoNumSTR);
                        Console.WriteLine("\n*************************************");

                        // Se realizan las operaciones correspondientes
                        int division = primerNumINT / segundoNumINT;
                        int residuo = primerNumINT % segundoNumINT;

                        // Se indica que se espere 1 segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("\nResultado: " + division + "\nResiduo: " + residuo);
                        Console.WriteLine("\n*************************************\n");
                        Thread.Sleep(500);
                        Console.WriteLine("Gracias por usar nuestro servicio " + usuario);
                        Console.WriteLine("\n*************************************\n");

                        // Preguntar si quiere guardarlo en un txt
                        string GuardarC1 = "";
                        while (GuardarC1 != "SI" && GuardarC1 != "NO")
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("¿Quíeres guardar el resultado en un txt? (SI|NO)");
                            Console.Write("-> ");
                            GuardarC1 = Console.ReadLine().ToUpper();
                            switch (GuardarC1)
                            {
                                case "SI":
                                    // Se borra primero lo que hay en la lista, para evitar duplicados
                                    //ListaResultado.Clear();

                                    // Se guarda lo que hay hasta el momento en la lista "ListaResultado"
                                    ListaResultado.Add("*************************************\n");
                                    ListaResultado.Add("Resultado de la #" + numDivision + " division!\n");
                                    ListaResultado.Add("[ " + primerNumINT + " / " + segundoNumINT + " ]\n");
                                    ListaResultado.Add("| Resultado: " + division);
                                    ListaResultado.Add("| Residuo: " + residuo);
                                    ListaResultado.Add("\n*************************************\n");

                                    // Se guarda en el archivo txt los datos que hay actualmente
                                    TextWriter tw = new StreamWriter(path);
                                    foreach (String s in ListaResultado)
                                        tw.WriteLine(s);
                                        tw.Close();

                                    Console.WriteLine("\nPerfecto, se han guardado los datos satisfactoriamente!");
                                    Console.WriteLine("\n*************************************");
                                    break;
                                case "NO":
                                    break;
                                default:
                                    Console.WriteLine("No es valido! Vuelva a intentar!\n");
                                    break;
                            }
                        }

                        // Preguntar si quiere continuar o no en el programa
                        string SeguirC1 = "";
                        while (SeguirC1 != "SI" && SeguirC1 != "NO")
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("\n¿Quíeres seguir continuando con el programa? (SI|NO)");
                            Console.Write("-> ");
                            SeguirC1 = Console.ReadLine().ToUpper();
                            switch (SeguirC1)
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

                    case 2:
                        Thread.Sleep(500);
                        numAreaRombo++;
                        Console.Clear();

                        Console.WriteLine("*****************************************");
                        Console.WriteLine("\nHas escodigo la opcion -> AREA DE ROMBO!\n");
                        Console.WriteLine("*****************************************\n");
                        Console.WriteLine("Ingrese su Diagonal mayor: ");
                        Console.Write("-> ");
                        string diagonalMayorSTR = Console.ReadLine();
                        int diagonalMayorINT = Convert.ToInt32(diagonalMayorSTR);
                        Console.WriteLine("\n------------------------\n");
                        Console.WriteLine("Ingrese su Diagonal menor: ");
                        Console.Write("-> ");
                        string diagonalMenorSTR = Console.ReadLine();
                        int diagonalMenorINT = Convert.ToInt32(diagonalMenorSTR);
                        int areaRombo = diagonalMayorINT * diagonalMenorINT / 2;

                        // Se indica que se espere medio segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("\n*************************************\n");
                        Console.WriteLine("El area del rombo es: " + areaRombo);
                        Console.WriteLine("\n*************************************\n");
                        Thread.Sleep(500);
                        Console.WriteLine("Gracias por usar nuestro servicio " + usuario);
                        Console.WriteLine("\n*************************************\n");
                        
                        // Preguntar si quiere continuar o no en el programa
                        string SeguirC2 = "";
                        while (SeguirC2 != "SI" && SeguirC2 != "NO")
                        {
                            Thread.Sleep(500);
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
                        Thread.Sleep(500);
                        numRaizElevada++;
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del que va a sacar raiz: ");
                        Console.Write("-> ");
                        string numRaizSTR = Console.ReadLine();
                        int numRaizINT = Convert.ToInt32(numRaizSTR);

                        Console.WriteLine("Ingrese el valor a elevar: ");
                        Console.Write("-> ");
                        string numElevadoSTR = Console.ReadLine();
                        int numElevadoINT = Convert.ToInt32(numElevadoSTR);

                        double re = Math.Sqrt(numRaizINT);
                        int rem = Convert.ToInt32(re);
                        double re2 = Math.Pow(rem, numElevadoINT);

                        // Se indica que se espere 1 segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("\n*************************************\n");
                        Console.WriteLine("La raiz del numero es: " + rem + ", elevado a " + numElevadoSTR + " sale: " + re2);
                        Console.WriteLine("\n*************************************\n");
                        Thread.Sleep(500);
                        Console.WriteLine("Gracias por usar nuestro servicio: " + usuario);
                        Console.WriteLine("\n*************************************\n");

                        // Preguntar si quiere continuar o no en el programa
                        string SeguirC3 = "";
                        while (SeguirC3 != "SI" && SeguirC3 != "NO")
                        {
                            Thread.Sleep(500);
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
                        Thread.Sleep(500);
                        numDivisas++;
                        Console.Clear();
                        Console.WriteLine("Ingrese la opcion de moneda a convertir: ");
                        Console.WriteLine("****************************************** ");
                        Console.WriteLine("MENU");
                        Console.WriteLine("1- DOLAR ");
                        Console.WriteLine("2- EURO ");
                        Console.WriteLine("3- RUBLO ");
                        Console.WriteLine("4- LEV ");
                        Console.WriteLine("5- BOLIVAR VENEZOLANO");
                        Console.WriteLine("****************************************** ");
                        string op = Console.ReadLine();
                        int opc = Convert.ToInt32(op);
                        switch (opc)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el monto a convertir: ");
                                string dolar = Console.ReadLine();
                                int dol = Convert.ToInt32(dolar);

                                int mont = dol * 19;
                                Console.WriteLine("****************************************** ");
                                Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                                Console.WriteLine("La conversion es de : " + mont + " pesos Mexicanos");

                                Console.WriteLine("****************************************** ");
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el monto a convertir: ");
                                string eur = Console.ReadLine();
                                int eu = Convert.ToInt32(eur);

                                int mont2 = eu * 20;
                                Console.WriteLine("****************************************** ");
                                Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                                Console.WriteLine("La conversion es de : " + mont2 + " pesos Mexicanos");

                                Console.WriteLine("****************************************** ");
                                break;

                            case 3:
                                Console.WriteLine("Ingrese el monto a convertir: ");
                                string rub = Console.ReadLine();
                                int ru = Convert.ToInt32(rub);

                                int mont3 = ru * 7;
                                Console.WriteLine("****************************************** ");
                                Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                                Console.WriteLine("La conversion es de : " + mont3 + " pesos Mexicanos");

                                Console.WriteLine("****************************************** ");
                                break;

                            case 4:
                                Console.WriteLine("Ingrese el monto a convertir: ");
                                string lev = Console.ReadLine();
                                int le = Convert.ToInt32(lev);

                                int mont4 = le * 10;
                                Console.WriteLine("****************************************** ");
                                Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                                Console.WriteLine("La conversion es de : " + mont4 + " pesos Mexicanos");

                                Console.WriteLine("****************************************** ");
                                break;

                            case 5:
                                Console.WriteLine("Ingrese el monto a convertir: ");
                                string bol = Console.ReadLine();
                                int bo = Convert.ToInt32(bol);

                                int mont5 = bo * 3;
                                Console.WriteLine("****************************************** ");
                                Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                                Console.WriteLine("La conversion es de : " + mont5 + " pesos Mexicanos");

                                Console.WriteLine("****************************************** ");
                                break;


                        }

                        // Preguntar si quiere continuar o no en el programa
                        string SeguirC5 = "";
                        while (SeguirC5 != "SI" && SeguirC5 != "NO")
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("¿Quíeres seguir continuando con el programa? (SI|NO)");
                            Console.Write("-> ");
                            SeguirC5 = Console.ReadLine().ToUpper();
                            switch (SeguirC5)
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

                    case 5:
                        Console.Clear();

                        // Se acaba el programa y se sale
                        Console.WriteLine("\nPerfecto, ha decidido salirse del programa!. Hasta pronto!\n");
                        return;

                }

                /*Console.WriteLine("Desear terminar el programa (SI(0)/NO(1))  " + usuario);
                Resp = Convert.ToInt32(Console.ReadLine());*/


            } while (Resp != 0);
        }
    }
}