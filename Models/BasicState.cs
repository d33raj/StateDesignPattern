using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo.Models
{
    internal class BasicState : IState
    {
        public string Name { get; set; }
        public double MinBalance { get; set; }
        public double MaxBalance { get; set; }

        public BasicState(string name,double minBalance,double maxBalance) 
        {
            Name = name;
            MinBalance = minBalance;
            MaxBalance = maxBalance;
        }
        public void GetBenefits()
        {
            Console.WriteLine("You don't have any Benefits. Please Upgrade to Any Plan.");
        }
    }
}
