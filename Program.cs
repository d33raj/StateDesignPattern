using StateDPDemo.Models;

namespace StateDPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Dheeraj", "SBI", 1200);
            account1.DisplayBenefits();
            account1.Deposit(12000);
            account1.DisplayBenefits();
            account1.Withdraw(5000);
            account1.DisplayBenefits();

            StateManager.AddState(new GoldState("Gold", 25000, 35000));
            Account account2 = new Account(102, "Nani", "Axis", 24000);
            account2.DisplayBenefits();
            account2.Deposit(2000);
            account2.DisplayBenefits();

        }
    }
}
