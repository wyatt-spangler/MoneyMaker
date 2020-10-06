using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert");
            string coins = Console.ReadLine();
            double conCoins = Convert.ToDouble(coins);
            int goldValue = 10;
            int silverValue = 5;
            double goldCoins = Math.Floor(coins / goldValue);
            double remainder = coins % goldValue;
            double silverCoins = Math.Floor(coins / silverValue);
            remainder = remainder % silverValue;
            Console.WriteLine(coins + $" cents is equal to...");
        }
    }
}