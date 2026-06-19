internal class Program
{
    private static void Main(string[] args)
    {
        int[] edadesPersonas = new int[7];
        int cantidadMayoresDeEdad = 0;

        for (int indice = 0; indice < 7; indice++)
        {
            Console.Write($"Ingrese la edad de la persona {indice + 1}: ");
            edadesPersonas[indice] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresDeEdad++;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresDeEdad);
    }
}
}