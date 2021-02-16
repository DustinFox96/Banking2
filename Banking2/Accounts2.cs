using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2 {
    class Accounts2 {
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public string Descrtipion { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; } = 0;
        public decimal MoneyDeposited { get; set; }
        public decimal MoneyWithdrawn { get; set; }

        public void deposit(decimal amount) {
            if(amount > 0) {
            Balance += amount;

            }
            //if(amount < 0) {
            //    return;
            //}
           
        }
            public void withdraw(decimal amount) {
            if(amount < 0) {
                
                Console.WriteLine($"go scam another bank");
                return;
            }

            if (Balance >= amount) {
                Balance -= amount;

            } else {
                Console.WriteLine($"No money for poor people");
            }
            
            }
        
    }
}
