using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo.Models
{
    internal interface IState
    {
        public string Name { get; set; }
        public double MinBalance { get; set; }
        public double MaxBalance { get; set; }
        void GetBenefits();
    }
}
