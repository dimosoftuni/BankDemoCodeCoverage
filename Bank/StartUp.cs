using System;

namespace Bank
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount dimo = new BankAccount(1000);

            Console.WriteLine("Sum is " + dimo.Amount);
            dimo.Withdraw(200);
            Console.WriteLine("Sum is " + dimo.Amount);

        }
    }
}
