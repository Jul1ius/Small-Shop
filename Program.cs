using System;

namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalSum = 0;

            if (city == "Sofia")
            {
                switch (type)
                {
                    case "coffee": totalSum = quantity * 0.50; break;
                    case "water": totalSum = quantity * 0.80; break;
                    case "beer": totalSum = quantity * 1.20; break;
                    case "sweets": totalSum = quantity * 1.45; break;
                    case "peanuts": totalSum = quantity * 1.60; break;
                }
            } 
            else if (city == "Plovdiv")
            {
                switch (type)
                {
                    case "coffee": totalSum = quantity * 0.40; break;
                    case "water": totalSum = quantity * 0.70; break;
                    case "beer": totalSum = quantity * 1.15; break;
                    case "sweets": totalSum = quantity * 1.30; break;
                    case "peanuts": totalSum = quantity * 1.50; break;
                }
            }
            else if (city == "Varna")
            {
                switch (type)
                {
                    case "coffee": totalSum = quantity * 0.45; break;
                    case "water": totalSum = quantity * 0.70; break;
                    case "beer": totalSum = quantity * 1.10; break;
                    case "sweets": totalSum = quantity * 1.35; break;
                    case "peanuts": totalSum = quantity * 1.55; break;      
                }
                {
                    Console.WriteLine(totalSum);
                }

            }

                    


            }
            
        }
    }

