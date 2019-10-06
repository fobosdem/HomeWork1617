using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class AccountClass<T>
    {
		private T Id { get; set; }
		private int Sum { get; set; }
		
		public List<string> Transactions { get; set; }
		
		public AccountClass(T newId, int newSum)
		{
			Id = newId;
			Sum = newSum;
			Transactions = new List<string>
			{
				$"Creating new account {newId} and pushing {Sum}$"
			};
		}

		public void TakeMoney(int takeMoney)
		{
			Sum -= takeMoney;
			Transactions.Add($"Account {Id}: taking {takeMoney}$, left {Sum}$");
		}

		public void AddMoney(int addMoney)
		{
			Sum += addMoney;
			Transactions.Add($"Account {Id}: adding {addMoney}$, left {Sum}$");
		}
    }
}
