using System;
using System;

class Program
{
    static void Main()
    {
        Queue<int> colaOriginal = GenerarColaAleatoria(100, -25, 25);

        Console.WriteLine("Cola Original:");
        MostrarCola(colaOriginal);

        Queue<int> colaNegativos = ObtenerColaNegativos(colaOriginal);

        Console.WriteLine("\nCola con Números Negativos:");
        MostrarCola(colaNegativos);
    }

    static Queue<int> GenerarColaAleatoria(int cantidad, int rangoMin, int rangoMax)
    {
        Random random = new Random();
        Queue<int> cola = new Queue<int>();

        for (int i = 0; i < cantidad; i++)
        {
            cola.Enqueue(random.Next(rangoMin, rangoMax + 1));
        }

        return cola;
    }

    static Queue<int> ObtenerColaNegativos(Queue<int> colaOriginal)
    {
        Queue<int> colaNegativos = new Queue<int>();

        foreach (int numero in colaOriginal)
        {
            if (numero < 0)
            {
                colaNegativos.Enqueue(numero);
            }
        }

        return colaNegativos;
    }

    static void MostrarCola(Queue<int> cola)
    {
        foreach (int elemento in cola)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
