using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsLibrary;

namespace ConsoleApp1
{
	class Program
	{
		static void Main()
		{
			CarsGeneric<Car> cars = new CarsGeneric<Car>();

			Car car1 = new Car("Honda", 222);
			Car car2 = new Car("Skoda", 182);
			Car car3 = new Car("Toyota", 213);
			Car car4 = new Car("BMW", 195);
			Car car5 = new Car("Ford", 167);

			cars.AddNewCar(car1);
			cars.AddNewCar(car2);
			cars.AddNewCar(car3);
			cars.AddNewCar(car4);
			cars.AddNewCar(car5);

			foreach(var car in cars.GetAllCars())
			{
				Console.WriteLine(car.ToString());
			}

			Console.WriteLine();

			int index = 2;
			Console.WriteLine($"Deleting car with index {index}");
			cars.DeleteCarByIndex(index);

			Console.WriteLine();

			foreach (var car in cars.GetAllCars())
			{
				Console.WriteLine(car.ToString());
			}

			Console.ReadKey();
		}
	}
}
