using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
	internal class UserInput
	{
		public UserInput() { }

		public void PrintMenu()
		{
			Console.WriteLine("Unit Converter");
			Console.WriteLine("1. Convert numbers");
			Console.WriteLine("2. Add alias");
			Console.WriteLine("3. Print quantities ");
		}
	}
}
