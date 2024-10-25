using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo.Models
{
    internal class BronzeState : IState
    {
        public string Name { get; set; }
        public double MinBalance { get; set; }
        public double MaxBalance { get; set; }

        public BronzeState(string name, double minBalance, double maxBalance)
        {
            Name = name;
            MinBalance = minBalance;
            MaxBalance = maxBalance;
        }
        public void GetBenefits()
        {
            Console.WriteLine("You Get 2% Cashback on every purchase you make.");
        }
    }
}
