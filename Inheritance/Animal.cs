using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Animal : Food
	{
		public string Sound { get; set; }
		public int Weight { get; set; }

		public Animal()
		{
			this.Type = FoodType.Live;
		}

		public virtual void Eat(Food food)
		{
			Console.WriteLine(Name + " : consumed: " + food);
		}

		//public Animal(int weight, string sound)
		//{
		//	Sound = sound;
		//	Weight = weight;
		//}


		public void Run()
		{
			Console.WriteLine("Running " + Weight);
		}

		public virtual void Jump()
		{
			Console.WriteLine("Jumping " + Sound);
		}

		public void Swim()
		{
			Console.WriteLine("Swimming");
		}
	}
}