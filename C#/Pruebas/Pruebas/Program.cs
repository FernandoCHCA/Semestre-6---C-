namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir la matriz para almacenar los nombres y las matrículas
            string[,] alumnos = new string[100, 2];

            // Inicializar el índice de la matriz
            int indice = 0;

            // Solicitar nombres y matrículas hasta que el usuario ingrese "fin"
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del alumno (o fin para terminar):");
                string nombre = Console.ReadLine();

                if (nombre == "fin")
                {
                    break;
                }

                Console.WriteLine("Ingrese la matrícula del alumno:");
                string matricula = Console.ReadLine();

                // Almacenar el nombre y la matrícula en la matriz
                alumnos[indice, 0] = nombre;
                alumnos[indice, 1] = matricula;

                // Incrementar el índice de la matriz
                indice++;
            }

            // Mostrar la lista completa de alumnos y sus matrículas
            Console.WriteLine("Lista de alumnos:");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(alumnos[i, 0] + " - " + alumnos[i, 1]);
            }

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();
        }
    }
}