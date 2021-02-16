using System;

namespace Banking2 {
    class Program {
        static void Main(string[] args) {
            var acct1 = new Accounts2(); 
            acct1.AccountNumber = "200";
            acct1.deposit(420);
            Console.WriteLine($"The Account number is {acct1.AccountNumber} And the balance after deposit is {acct1.Balance}");
            acct1.withdraw(69);
            Console.WriteLine($"The Account number is {acct1.AccountNumber} And the balance withdraw is {acct1.Balance}");
            acct1.withdraw(420);
            Console.WriteLine($"The Account number is {acct1.AccountNumber} And the balance withdraw is {acct1.Balance}");
            acct1.withdraw(-300);
            acct1.deposit(1.50m);
            Console.WriteLine($"The Account number is {acct1.AccountNumber} And the balance after deposit is {acct1.Balance}");
            acct1.deposit(-100);
            Console.WriteLine($"The Account number is {acct1.AccountNumber} And the balance after deposit is {acct1.Balance}");




        }
    }
}
