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
            Console.WriteLine("***********************************************************************\n");
            Console.WriteLine("Ingrese su nombre: ");
            Console.Write("-> ");
            string usuario = Console.ReadLine();
            Console.WriteLine("\nBienvenido " + usuario + " al programa! Esperemos y te la pases bien!");
            Console.WriteLine("\n***********************************************************************");
            Thread.Sleep(3000);

            do
            {
                Console.Clear();
                Console.WriteLine("******************************************\n");
                Console.WriteLine("Bienvenido! Escoge la opcion que quieras: \n");
                Console.WriteLine("1- DIVISION ");
                Console.WriteLine("2- AREA DE ROMBO ");
                Console.WriteLine("3- RAIZ ELEVADA ");
                Console.WriteLine("4- SERIE FIBONACCI ");
                Console.WriteLine("5- DIVISAS");
                Console.WriteLine("6- SALIR DEL PROGRAMA");
                Console.WriteLine("\n******************************************");
                Console.WriteLine("\nSeleccione una opción: ");
                Console.Write("-> ");
                string opcionMenuSTR = Console.ReadLine();
                int opcionMenuINT = Convert.ToInt32(opcionMenuSTR);
                switch (opcionMenuINT)
                {
                    case 1:
                        Thread.Sleep(1000);
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

                        // Preguntar si quiere continuar o no en el programa
                        string SeguirC1 = "";
                        while (SeguirC1 != "SI" && SeguirC1 != "NO")
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("¿Quíeres seguir continuando con el programa? (SI|NO)");
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
                        Thread.Sleep(1000);
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
                        // Se indica que se espere 1 segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("\n*************************************\n");
                        Console.WriteLine("El area del rombo es : " + areaRombo);
                        Thread.Sleep(500);
                        Console.WriteLine("Gracias por usar nuestro servicio " + usuario);
                        Console.WriteLine("\n*************************************\n");
                        Console.ReadLine();
                        break;

                    case 3:
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero que va a sacar raiz: ");
                        string n1 = Console.ReadLine();
                        int na = Convert.ToInt32(n1);

                        Console.WriteLine("Ingrese el valor a elevar: ");
                        string n2 = Console.ReadLine();
                        int nb = Convert.ToInt32(n2);

                        double re = Math.Sqrt(na);
                        int rem = Convert.ToInt32(re);
                        double re2 = Math.Pow(rem, nb);
                        // Se indica que se espere 1 segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("****************************************** ");
                        Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                        Console.WriteLine("la raiz del numero es : " + rem + ", elevado a " + nb + " sale : " + re2);

                        Console.WriteLine("****************************************** ");
                        Console.ReadLine();
                        break;

                    case 4:
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Insertar los Valores para la serie Fibonacci");
                        string respuesta_v = Console.ReadLine();
                        int respuesta_int = Convert.ToInt32(respuesta_v);
                        int a = 1, b = 0;
                        // Se indica que se espere 1 segundo para que aparezca lo siguiente
                        Thread.Sleep(500);
                        Console.WriteLine("****************************************** ");
                        Console.WriteLine("Gracias por usar nuestro servicio : " + usuario);
                        Console.WriteLine("*******SERIE FIBORACCI*******");
                        for (int contador = 0; contador <= respuesta_int; contador++)
                        {

                            int resultado = a + b;
                            Console.WriteLine(resultado);
                            b = a;
                            a = resultado;
                        }

                        Console.WriteLine("****************************************** ");

                        break;

                    case 5:
                        Thread.Sleep(1000);
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
                                Console.ReadLine();
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
                                Console.ReadLine();
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
                                Console.ReadLine();
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
                                Console.ReadLine();
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
                                Console.ReadLine();
                                break;


                        }

                        break;
                    case 6:
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