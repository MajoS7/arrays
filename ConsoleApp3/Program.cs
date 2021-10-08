using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas tardes, tiene las siguientes opciones: ");
            Console.WriteLine("1 - Crea una Lista con un tamaño de 10, inserta los valores numéricos que desees de la manera que quieras y muestra por pantalla la media de valores del array.");
            Console.WriteLine("\n2 - Crea una Lista donde tu le indiques el tamaño por teclado y crear una función que rellene el array o arreglo con los múltiplos de un numero pedido por teclado.");
            Console.WriteLine("\n3 - Buscar un elemento dentro de una lista que nosotros le pedimos por teclado. Indicar las posición donde se encuentra. Si hay más de uno, indicar igualmente la posición.");
            Console.Write("\nPor favor digite el numero de la opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            string texto="";
            switch (opcion)
            {
                case 1:
                    decimal suma = 0;

                    //primera forma
                    decimal [] Arraynumeros = new decimal[10];


                    for (int i = 0; i < Arraynumeros.Length; i++)
                    {
                        Console.Write("Ingrese numero: ");
                        decimal numero = Convert.ToDecimal(Console.ReadLine());
                        Arraynumeros[i] = numero;
                        texto = texto + "+" + Convert.ToString(numero);
                        suma = suma + numero;
                    }
                    decimal media = suma / 10;

                    Console.WriteLine("Suma = " + texto + " = " + suma);
                    Console.Write("Media = " + suma + "/10 = " + Convert.ToString(media));

                    break;

                case 2:
                    texto = "";

                    //segunda forma
                    Console.Write("Por favor digite el tamaño del array o multiplos que quiere: ");
                    int tamañoa = (Convert.ToInt32(Console.ReadLine()));
                    int[] Arrayn = new int[tamañoa];


                    Console.Write("Por favor digite el numero a multiplicar: ");
                    int n = (Convert.ToInt32(Console.ReadLine()));
                    int multiplicar = 1;
                    for (int i=0; i < Arrayn.Length; i++)
                    {
                        int mul = n * multiplicar;
                        Arrayn[i] = mul;
                        texto = texto + ", "+Convert.ToString(mul);
                        multiplicar++;
                    }
                    Console.Write("Los multiplos de "+Convert.ToString(n)+" son: "+texto);
                    break;

                case 3:
                    texto = "";
                    Console.Write("Por favor digite el tamaño del array: ");
                    int tamañoar = (Convert.ToInt32(Console.ReadLine()));
                    int [] Arraynum = new int[tamañoar];
                    
                    for (int i = 0; i < Arraynum.Length; i++)
                    {
                        Console.Write("Digite el valor del elemento: ");
                        int elemento = (Convert.ToInt32(Console.ReadLine()));
                        Arraynum[i] = elemento;
                    }


                    Console.Write("Que quiere buscar: ");
                    int busquedad = (Convert.ToInt32(Console.ReadLine()));
                    
                    for (int i=0; i<Arraynum.Length; i++)
                    {
                        if (busquedad == Arraynum[i])
                        {
                            texto = texto +", " + Convert.ToString(i);

                        }
                   
                    }
                    Console.Write("La posicion de " + Convert.ToString(busquedad) + " es: " + texto);
                    break;

		default:
                    Console.WriteLine("Por favor digite un numero dentro de las opciones" );
                    break;


            }
        }
    }
}
