using System;

namespace Inheritance
{
	public class Mouse
	{
		public int Weight { get; set; }
		public string Sound { get; set; }

		public void Run()
		{
			Console.WriteLine("Running");
		}

		public void Jump()
		{
			Console.WriteLine("Jumping");
		}

		public void Swim()
		{
			Console.WriteLine("Swimming");
		}
	}
}