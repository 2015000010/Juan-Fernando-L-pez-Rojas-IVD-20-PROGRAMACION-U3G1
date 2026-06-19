internal class Program
{
    private static void Main(string[] args)
    {
        int[] numEnteros = new int[8];
        int numMayor = 0;
        int posMayor = 0;

        for (int indice = 0; indice < 8; indice++)
        {
            Console.Write($"Ingrese el número {indice + 1}: ");
            numEnteros[indice] = int.Parse(Console.ReadLine());

            if (indice == 0)
            {
                numMayor = numEnteros[indice];
                posMayor = indice + 1;
            }
            else
            {
                if (numEnteros[indice] > numMayor)
                {
                    numMayor = numEnteros[indice];
                    posMayor = indice + 1;
                }
            }
        }

        Console.WriteLine("El número mayor es: " + numMayor);
        Console.WriteLine("La posición es: " + posMayor);
    }
}
}