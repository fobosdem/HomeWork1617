using System.Collections;
using System.Collections.Generic;

namespace CarsLibrary
{
	public class CarsGeneric<T> : IEnumerable<T>
	{
		private readonly LinkedList<T> carsLinkedList;

		public CarsGeneric()
		{
			carsLinkedList = new LinkedList<T>();
		}

		public void AddNewCar(T newCar)
		{
			if (carsLinkedList.Count == 0)
			{
				carsLinkedList.AddFirst(newCar);
			}
			else
				carsLinkedList.AddAfter(carsLinkedList.Last, newCar);
		}

		public void DeleteCarByIndex(int index)
		{
			int i = 0;
			if (index <= carsLinkedList.Count && index > 0)
			{
				foreach (var a in carsLinkedList)
				{
					if (i == index)
					{
						carsLinkedList.Remove(a);
						break;
					}
					i++;
				}
			}
		}

		public IEnumerable<T> GetAllCars()
		{
			foreach (var a in carsLinkedList)
			{
				yield return a;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			return carsLinkedList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return carsLinkedList.GetEnumerator();
		}
	}
}

