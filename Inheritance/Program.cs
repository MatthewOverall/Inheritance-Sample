using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Program
	{
		public static void Main()
		{
			var loki = new Cat()
			{
				Name = "Loki",
				Sound = "Meow",
				Weight = 5
			};

			var ruger = new Dog()
			{
				Name = "Ruger",
				Sound = "WOOOF!",
				Weight = 120,
				Breed = "PitBull"
			};

			var chimChim = new Monkey
			{
				Name = "Chim Chim",
				Sound = "Banshee Scream",
				Weight = 320
			};

			var catFood = new CatFood
			{
				Name = "CatFood",
				ExpirationDate = DateTime.Today.AddYears(-7),
				Type = FoodType.Processed
			};

			var dogFood = new DogFood()
			{
				Name = "Blue Buffalo",
				ExpirationDate = DateTime.Now.AddMonths(1),
				Type = FoodType.Processed
			};

			var classAnimals = new List<Animal>();
			classAnimals.Add(loki);
			classAnimals.Add(ruger);
			classAnimals.Add(chimChim);

			foreach (var animal in classAnimals)
			{
				Console.WriteLine(animal.Name);
				chimChim.Eat(animal);
			}

			Console.ReadLine();
		}
	}
}