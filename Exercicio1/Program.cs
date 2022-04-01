using System;
using System.Threading;
using System.Diagnostics;

class Program
{
    public static int[] numeroSorteado = new int[200];
    public static int valorMinimo = 10;
    public static int valorMaximo = 100;
    public static int soma1 = 0;
    public static int soma2 = 0;
    public static int somaTotal = 0;

    static void Main()
    {
        Random numeroAleatorio = new Random();

        var stopWatch = new Stopwatch();

       

        stopWatch.Start();

        for (int i = 0; i < (numeroSorteado.Length); i++)
        {
            numeroSorteado[i] = numeroAleatorio.Next(valorMinimo, valorMaximo);
        }


        
        
        Thread t1 = new Thread(Thread1);
        t1.Start();
        
        Thread t2 = new Thread(Thread2);
        t2.Start();
        
        t1.Join();
        t2.Join();

        somaTotal = soma1 + soma2;
        Console.WriteLine("\nValor das duas Threads somadas:" + somaTotal);

        stopWatch.Stop();

        Console.WriteLine($"O Tempo de processamento total é de {stopWatch.ElapsedMilliseconds}ms");


    }
    private static void Thread1()
    {
        PularLinha();

        Console.WriteLine("Numeros Sorteados Thread 1:");

        for (int i = 0; i < numeroSorteado.Length / 2; i++)
        {
           Console.Write(numeroSorteado[i] + " - ");
            soma1 += numeroSorteado[i];

        }

        PularLinha();
        Console.WriteLine("\nSoma dos valores da  Thread 1: " + soma1);
        
    }
    private static void Thread2()
    {
        PularLinha();

        Console.WriteLine("Numeros Sorteados Thread 2:");

        for (int i = (numeroSorteado.Length)/2; i <numeroSorteado.Length; i++)
        {
            Console.Write(numeroSorteado[i] + " - ");
            soma2 += numeroSorteado[i];

        }

        PularLinha();
        Console.WriteLine("\nSoma Thread 2: " + soma2);
        
    }

    public static void PularLinha()
    {
        Console.WriteLine(" ");
    }
}
