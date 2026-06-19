internal class Program
{
    private static void Main(string[] args)
    {
        int[] numEnteros = new int[15];
        bool existeRepetido = false;

        for (int indice = 0; indice < 15; indice++)
        {
            Console.Write($"Ingrese el número {indice + 1}: ");
            numEnteros[indice] = int.Parse(Console.ReadLine());
        }

        for (int indice = 0; indice < 14; indice++)
        {
            for (int comparador = indice + 1; comparador < 15; comparador++)
            {
                if (numEnteros[indice] == numEnteros[comparador])
                {
                    existeRepetido = true;
                }
            }
        }

        if (existeRepetido)
        {
            Console.WriteLine("Sí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido.");
        }
    }
}