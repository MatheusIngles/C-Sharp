using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class BankAccount
    {
        
        static private int accountNumberSeed = 0;
        string number, owner;
        public float Balance;

        public BankAccount(string number, string owner, float Balance) {
            this.number = number;
            this.owner = owner;
            this.Balance = Balance;
            accountNumberSeed++;
        }

        public void MakeDeposit(float Deposito)
        {
            Balance += Deposito;
        }

        public void MakeWithdrawal(float Saque) 
        { 
            Balance -= Saque;
        }
    }
}
