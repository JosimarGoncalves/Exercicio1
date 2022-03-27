using System;
using System.Threading;

class Program
{
    public static int[] numeroSorteado = new int[100];
    public static int valorMinimo = 10;
    public static int valorMaximo = 100;
    public static int somaA = 0;
    public static int somaB = 0;

    static void Main()
    {
        Random numeroAleatorio = new Random();

        Console.WriteLine("Numeros Sorteados:" );

        for (int i = 0; i < (numeroSorteado.Length); i++)
        {
            numeroSorteado[i] = numeroAleatorio.Next(valorMinimo, valorMaximo);
        }


    }
    private void Thread1()
    {
        for (int i = 0; i < numeroSorteado.Length / 2; i++)
        {
           Console.WriteLine(numeroSorteado[i] + " ");

        }
    }
}