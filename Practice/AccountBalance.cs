using System;

namespace Practice
{
    public class AccountBalance
    {
        public static int processTransactions(int startingBalance, string[] transactions)
        {
            foreach (string transaction in transactions)
            {
                var elements = transaction.Split(' ');
                var amount = Convert.ToInt32(elements[1]);
                if (elements[0] == "D")
                {
                    startingBalance -= amount;
                }
                else
                {
                    startingBalance += amount;
                }
            }
            return startingBalance;
        }
    }
}
