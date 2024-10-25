using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo.Models
{
    internal class SilverState : IState
    {
        public string Name { get; set; }
        public double MinBalance { get; set; }
        public double MaxBalance { get; set; }

        public SilverState(string name,double minBalance, double maxBalance)
        {
            Name = name;
            MinBalance = minBalance;
            MaxBalance = maxBalance;
        }
        public void GetBenefits()
        {
            Console.WriteLine("You Get 5% Cashback on every purchase you make, Along with specific offers on shopping.");
        }
    }
}
