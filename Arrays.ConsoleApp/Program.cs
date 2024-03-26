namespace Arrays.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

        // Mostrando valores
        Console.WriteLine("Valores do array: ");
        MostrarArray(array);

        // Maior Valor
        Console.WriteLine("Maior valor da sequência: ");
        Console.WriteLine(MaiorValorArray(array));

        // Menor Valor
        Console.WriteLine("Menor valor da sequência: ");
        Console.WriteLine(MenorValor(array));

        // Média
        Console.WriteLine("Média da sequência: ");
        Console.WriteLine(MediaArray(array).ToString("F2"));

        // 3 maiores valores
        Console.WriteLine("3 maiores valores da sequência: ");
        TresMaioresValores(array);

        // Valores negativos
        Console.WriteLine("Valores negativos: ");
        ValorNegativo(array);
        
        // Removendo
        RemovendoItem(array);
    }

    static void RemovendoItem(int[] array)
    {
        int posicaoParaRemover = Array.IndexOf(array, 11);


        int[] novoArray = new int[array.Length - 1];

        int contadorItems = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int valorAtual = array[i];
            if (i != posicaoParaRemover)
            {
                novoArray[contadorItems] = array[i];
                contadorItems++;
            }
        }

        Console.WriteLine("Sequência apó remoção: ");
        MostrarArray(novoArray);
    }

    static void TresMaioresValores(int[] array)
    {
        int[] copiaArray = new int[array.Length];

        Array.Copy(array, copiaArray, array.Length);
        Array.Sort(copiaArray);
        Array.Reverse(copiaArray);

        Console.WriteLine($"{copiaArray[0]}, {copiaArray[1]}, {copiaArray[2]}");
    }

    static int MaiorValorArray(int[] array)
    {
        int maiorValor = int.MinValue;

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
        int menorValor = int.MaxValue;

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
        /*
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
        */
        Console.WriteLine($"{string.Join(", ", array)}");
    }
}
