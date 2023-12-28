internal class Program
{
    private static void Main(string[] args)
    {
         // Declara un array para almacenar los 6 números
        int[] numeros = new int[6];

        // Solicita al usuario que ingrese 6 números
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Ingrese el número {0}: ", i + 1);
            // Lee el número ingresado por el usuario y lo convierte a entero
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Imprime los números en orden inverso
        Console.WriteLine("\nNúmeros en orden inverso:");

        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }

        // Espera que el usuario presione una tecla antes de cerrar la aplicación
        Console.ReadLine();
    }
}