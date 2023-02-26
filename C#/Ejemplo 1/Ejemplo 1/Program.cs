Console.WriteLine("Ingresa un primer valor");
String dato_valor1 = Console.ReadLine();
int primer_valor = Convert.ToInt32(dato_valor1);

Console.WriteLine("\nIngresa un segundo valor");
String dato_valor2 = Console.ReadLine();
int segundo_valor = Convert.ToInt32(dato_valor2);

int suma = primer_valor + segundo_valor;
int resta = primer_valor - segundo_valor;
int multiplicacion = primer_valor * segundo_valor;
int division = primer_valor / segundo_valor;

Console.WriteLine("\nEl resultado de la suma es: " + suma);
Console.WriteLine("El resultado de la resta es: " + resta);
Console.WriteLine("El resultado de la multiplicacion es: " + multiplicacion);
Console.WriteLine("El resultado de la division es: " + division);

