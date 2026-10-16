using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME to MY SIMPLE GAME program.");

        Random num = new Random();
        Stack<int> playerA = new Stack<int>();
        Stack<int> playerB = new Stack<int>();

        for (int i = 0; i < 10; i++)
        {
            playerA.Push(num.Next(0, 10));
        }

        for (int i = 0; i < 10; i++)
        {
            playerB.Push(num.Next(0, 10));
        }

        int[] arrA = playerA.ToArray();
        int[] arrB = playerB.ToArray();
        Array.Reverse(arrA);
        Array.Reverse(arrB);

        Console.Write("Player A: ");
        foreach (int item in arrA)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nPlayer B: ");
        foreach (int item in arrB)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
        int rounds = 1;
        int winsA = 0;
        int winsB = 0;

        while (playerA.Count > 0 && playerB.Count > 0)
        {
            int cardA = playerA.Peek();
            int cardB = playerB.Peek();

            Console.WriteLine($"Match {rounds}: ");
            Console.WriteLine($"{cardA} vs {cardB}");

            if (cardA > cardB)
            {
                playerB.Pop();
                Console.WriteLine("Player A win");
                winsA++;
            }
            else if (cardB > cardA)
            {
                playerA.Pop();
                winsB++;
                Console.WriteLine("Player B win");
            }
            else 
            {
                playerA.Pop();
                playerB.Pop();
                Console.WriteLine("Rematch\n");
            }
            rounds++;
        }
        Console.WriteLine("\n");

        Console.WriteLine("Final Result: ");
        int[] fArray = playerA.ToArray();
        Array.Reverse(fArray);
        Console.Write("Player A: ");
        foreach (int item in fArray)
        {
            Console.Write(item + " ");
        }
        int[] fArrayB = playerB.ToArray();
        Array.Reverse(fArrayB);
        Console.Write("\nPlayer B: ");
        foreach (int item in fArrayB)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        if (winsA > winsB)
        {
            Console.WriteLine("Player A win.");
        }
        else if (winsB > winsA)
        {
            Console.WriteLine("Player B win.");
        }
        else
        {
            Console.WriteLine("The game is a tie!");
        }

    }


}
