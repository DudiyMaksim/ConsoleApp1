using System;
using System.Threading;

internal class ConsoleApp1
{
    static void Print50()
    {
        int i = 0;
        while (i < 51)
        {
            Console.WriteLine($"{i}: Text by thread");
            i++;
        }
    }


    struct StartEnd {
        public int start;
        public int end;
    }
    static void PrintRange(object? obj)
    {
        StartEnd range = (StartEnd)obj;
        int i = range.start;
        while (i < range.end + 1)
        {
            Console.WriteLine($"{i}: Text by thread");
            i++;
        }
    }


    static void ThreadMax(object? obj)
    {
        int[] numbers = (int[])obj;
        int max = 0;
        foreach (int item in numbers)
        {
            if (item > max) { 
                max = item;
            }
        }
        Console.WriteLine("Max of numbers = " + max);
    }
    static void ThreadMin(object? obj)
    {
        int[] numbers = (int[])obj;
        int min = 0;
        foreach (int item in numbers)
        {
            if (item<min) { 
            min = item;
            }
        }
        Console.WriteLine("Min of numbers = " + min);
    }
    static void ArithmeticMean(object? obj)
    {
        int[] numbers = (int[])obj;
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine("Arithmetic mean of numbers = " + (sum / numbers.Length));
    }



    static void Fibonacci()
    {
        int n0 = 1;
        int n1 = 1;
        int next;
        while (true)
        {
            Console.WriteLine(n0 + n1);
            next = n0 + n1;
            n0 = n1;
            n1 = next;

            Thread.Sleep(1000);
        }
    }
    static void Main(string[] args)
    {
        ////task 1
        //ThreadStart threadStart = new ThreadStart(Print50);
        //Thread thread = new Thread(threadStart);
        //thread.Start();
        ////task 2
        //StartEnd SE = new StartEnd();
        //Console.Write("Start: ");
        //SE.start = int.Parse(Console.ReadLine());

        //Console.Write("End: ");
        //SE.end = int.Parse(Console.ReadLine());
        //Thread thread2 = new Thread(PrintRange);
        //thread2.Start(SE);
        ////task 4
        //int[] numbers = new int[1000];
        //Random random = new Random();
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = random.Next(1, 10000);
        //}

        //Thread threadMax = new Thread(ThreadMax);
        //threadMax.Start(numbers);
        //Thread threadMin = new Thread(ThreadMin);
        //threadMin.Start(numbers);
        //Thread threadArithmeticMean = new Thread(ArithmeticMean);
        //threadArithmeticMean.Start(numbers);
        ////task 5
        //Thread F = new Thread(Fibonacci);
        //F.Start();
    }
}