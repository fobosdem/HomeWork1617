using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
	public class Car
	{
		public string Name { get; private set; }
		public int HorsePowers { get; private set; }

		public Car(string name, int hp)
		{
			Name = name;
			HorsePowers = hp;
		}

		public override string ToString()
		{
			return $"Car {Name} has {HorsePowers} horsepowers";
		}
	}
}
