using StateDPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        private IState _state;

        public Account(int accountId,string name,string bankName,double balance)
        {
            AccountId = accountId;
            Name = name;
            BankName = bankName;
            Balance = balance;
            _state=StateManager.GetState(this);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            var newState = StateManager.GetState(this);
            if (newState != null)
            {
                _state = newState;
            }
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            var newState = StateManager.GetState(this);
            if (newState != null)
            {
                _state = newState;
            }
        }

        public void DisplayBenefits()
        {
            _state.GetBenefits();
        }

    }
}
