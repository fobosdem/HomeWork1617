using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;

namespace ConsoleApp1
{
	class Program
	{
		static void Main()
		{
			AccountClass<int> firstAccount = new AccountClass<int>(12345, 100);
			AccountClass<double> secondAccount = new AccountClass<double>(12.2, 50);
			AccountClass<Guid> thirdAccount = new AccountClass<Guid>(Guid.NewGuid(), 200);

			firstAccount.AddMoney(200);
			firstAccount.TakeMoney(50);
			firstAccount.TakeMoney(25);

			secondAccount.TakeMoney(100);
			secondAccount.AddMoney(2000);

			thirdAccount.AddMoney(35);
			thirdAccount.AddMoney(200);
			thirdAccount.AddMoney(47);

			Console.WriteLine("First acc transactions");
			foreach(string transaction in firstAccount.Transactions)
			{
				Console.WriteLine(transaction);
			}

			Console.WriteLine("Second acc transactions");
			foreach (string transaction in secondAccount.Transactions)
			{
				Console.WriteLine(transaction);
			}

			Console.WriteLine("Third acc transactions");
			foreach (string transaction in thirdAccount.Transactions)
			{
				Console.WriteLine(transaction);
			}

			Console.ReadKey();
		}
	}
}
