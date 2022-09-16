using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities {
    class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance) {
            InterestRate = interestRate;
        }
        public override void Withdraw(double amount) {
            Balance -= amount;
        }
        public void updateBalance() {
            Balance += Balance * InterestRate;
        }

    }
}
