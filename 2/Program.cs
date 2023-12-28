internal class Program
{
    private static void Main(string[] args)
    {
        // Declarar un array para almacenar los nombres
        string[] nombres = new string[100];
        int contador = 0;

        Console.WriteLine("Introduce nombres (escribe 'stop' para finalizar):");

        // Bucle para pedir nombres hasta que se ingrese 'stop' o se alcance el límite de 100 nombres
        while (contador < 100)
        {
            Console.Write("Nombre {0}: ", contador + 1);
            string nombre = Console.ReadLine();

            // Verificar si se debe detener la entrada de nombres
            if (nombre.ToLower() == "stop")
            {
                break;
            }

            // Almacenar el nombre en el array
            nombres[contador] = nombre;
            contador++;
        }

        // Mostrar la lista de nombres
        Console.WriteLine("\nLista de nombres introducidos:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        // Esperar que el usuario presione una tecla antes de cerrar la aplicación
        Console.ReadLine();
    }
}