using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Only_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Hello! I'm Cash Only Assistant 2.0! \n How many items are we selling?");
            int items = int.Parse(Console.ReadLine());
            double[] prices = new double[items];
            for (int meo = 1; meo < prices.Length + 1; meo++)
            {
                Console.WriteLine("Enter item " + meo + "'s price");
                prices[meo - 1] = double.Parse(Console.ReadLine());
            }
            double subtot = 0;
            for (int ino = 0; ino < prices.Length; ino++)
            {
                subtot = subtot + prices[ino];
            }
            Console.WriteLine("Your subtotal is " + subtot + "! \n What is your tax rate?");
            double taxrate = double.Parse(Console.ReadLine());
            double tax = Math.Round(subtot * (taxrate / 100), 2);
            double total = Math.Round(subtot + tax, 2);
            Console.WriteLine("Your Total is " + total + "! \n How much cash is the customer paying with?");
            double cash = double.Parse(Console.ReadLine());
            double amount = Math.Round(cash - total, 2);
            int b100 = 0;
            int b50 = 0;
            int b20 = 0;
            int b10 = 0;
            int b5 = 0;
            int b1 = 0;
            int c25 = 0;
            int c10 = 0;
            int c05 = 0;
            int c01 = 0;
            Console.WriteLine("Change needed is " + amount + "!");
            while (amount > 0)
            {
                if (amount >= 100)
                {
                    amount = amount - 100;
                    b100++;
                }
                else if (amount >= 50)
                {
                    amount = amount - 50;
                    b50++;
                }
                else if (amount >= 20)
                {
                    amount = amount - 20;
                    b20++;
                }
                else if (amount >= 10)
                {
                    amount = amount - 10;
                    b10++;
                }
                else if (amount >= 5)
                {
                    amount = amount - 5;
                    b5++;
                }
                else if (amount >= 1)
                {
                    amount = amount - 1;
                    b1++;
                }
                else if (amount >= .25)
                {
                    amount = Math.Round((amount - .25), 2);
                    c25++;
                }
                else if (amount >= .10)
                {
                    amount = Math.Round((amount - .10), 2);
                    c10++;
                }
                else if (amount >= .05)
                {
                    amount = amount - .05;
                    c05++;
                }
                else
                {
                    amount = Math.Round((amount - .01), 2);
                    c01++;
                }
            }

            Console.WriteLine("You will need " + b100 + " 100s.");

            Console.WriteLine("You will need " + b50 + " 50s.");

            Console.WriteLine("You will need " + b20 + " 20s.");

            Console.WriteLine("You will need " + b10 + " 10s.");
            Console.WriteLine("You will need " + b5 + " 5s.");

            Console.WriteLine("You will need " + b1 + " 1s.");

            Console.WriteLine("You will need " + c25 + " quarters.");

            Console.WriteLine("You will need " + c10 + " dimes.");

            Console.WriteLine("You will need " + c05 + " nickels.");

            Console.WriteLine("You will need " + c01 + " pennies.");
            Console.ReadKey();
            Console.WriteLine("Continue? 1 for yes.");
            int again = int.Parse(Console.ReadLine());
            if(again == 1)
            {
                Console.Clear();
                goto Start;
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}
