namespace Arrays.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

        MostrarArray(array);

        Console.WriteLine("Maior valor da sequência: ");
        Console.WriteLine(MaiorValorArray(array));

        Console.WriteLine("Menor valor da sequência: ");
        Console.WriteLine(MenorValor(array));

        Console.WriteLine("Média da sequência: ");
        Console.WriteLine(MediaArray(array).ToString("F2"));

        Console.WriteLine("3 maiores valores da sequência: ");

        Console.WriteLine("Valores negativos: ");
        ValorNegativo(array);

        Console.WriteLine("Todos os valores da sequência: ");
        MostrarArray(array);

        Console.WriteLine("Remover um item da sequência: ");
    }

    static int MaiorValorArray(int[] array)
    {
        int maiorValor = 0;

        for (int i = 0; i < array.Length ; i++)
        {
            if (i == 0)
            {
                maiorValor = array[0];
            }
            else if (array[i] > maiorValor)
            {
                maiorValor = array[i];
            }
        }

        return maiorValor;
    }

    static int MenorValor(int[] array)
    {
        int menorValor = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                menorValor = array[0];
            }
            else if (array[i] < menorValor)
            {
                menorValor = array[i];
            }
        }

        return menorValor;
    }

    static double MediaArray(int[] array)
    {
        double total = 0;

        for (int i = 0; i < array.Length ; i++) 
        {
            total += array[i];
        }

        return total / array.Length;
    }

    static void ValorNegativo(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.WriteLine();
    }

    static void MostrarArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
