using System;

class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = false;

        Random numrandom = new Random();
        int winrate = 0;
        int count = 0;

        while (isRunning == false)
        {
            int num = numrandom.Next(1, 11);
            if (num < 6)
            {
                Console.WriteLine("It is less than 6");
            }
            else
            {
                Console.WriteLine("it is higher than 6");
            }
            Console.Write("enter the gass number : ");
            int gass = int.Parse(Console.ReadLine());
            if (gass == num)
            {
                Console.WriteLine("you win");
                winrate++;
            }
            else
            {
                Console.WriteLine("you lose the number is : ");
            }

            count++;

            if (count == 11)
            {
                isRunning = true;
            }

        }
        if (winrate > 0)
        {
            Console.WriteLine($"you win {winrate} times");
        }
        else
        {
            Console.WriteLine("you lose sorry !");
        }
    }
}
