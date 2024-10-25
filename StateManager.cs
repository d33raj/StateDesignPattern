using StateDPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDPDemo
{
    internal class StateManager
    {
        private static List<IState> _states = new List<IState>()
        {
            new BasicState("Basic",500,10000),
            new BronzeState("Bronze",10000,15000),
            new SilverState("Silver",15000,25000)
        };

        public static IState GetState(Account account)
        {
            for (int i = 0; i < _states.Count; i++)
            {
                if (account.Balance >= _states[i].MinBalance && account.Balance < _states[i].MaxBalance)
                {
                    return _states[i];
                }
            }
            return null;
        }

        public static void AddState(IState state)
        {
            _states.Add(state);
        }
    }
}
