using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

		private double _balance;

		public double Deposit(double num)
		{
			return _balance += num;
		}

		public double GetBalance() => _balance;

		public double Withdraw(double amount) => amount <= _balance ? _balance -= amount : -1;
	}
}

