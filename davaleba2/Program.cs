using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            int amount = 63;
            int minCoins = MinSplit(amount);
            Console.WriteLine($"Minimum number of coins to make up {amount} is {minCoins}");

        }

        public static int MinSplit(int amount)
        {
            int[] coins = { 50, 20, 10, 5, 1 };
            int[] dp = new int[amount + 1];

            for (int i = 1; i <= amount; i++)
            {
                dp[i] = int.MaxValue;
                foreach (int coin in coins)
                {
                    if (i >= coin && dp[i - coin] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            return dp[amount];
        }


    }
}
