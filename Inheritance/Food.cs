using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Food
	{
		public string Name;
		public DateTime ExpirationDate;
		public FoodType Type;

		public override string ToString()
		{
			return Name;
		}
	}

	public enum FoodType
	{
		Vegetable,
		Live,
		Processed
	}
}