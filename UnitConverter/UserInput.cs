using System;
using unit_conversion.Models;

namespace unit_converter
{
	internal class UserInput
	{
		private readonly UnitConverter _unitConverter;

		public UserInput() 
		{
			_unitConverter = new UnitConverter(@"..\..\..\..\POSC.xml");
		}

		public UnitConverter Converter { get { return _unitConverter; } private set {; } }

		public bool PrintMainMenu()
		{
			Console.WriteLine("Unit Converter");
			Console.WriteLine("1. Convert numbers");
			Console.WriteLine("2. Manage Aliases");
			Console.WriteLine("3. Manage quantities");
			Console.WriteLine("4. Quit");
			int? menuChoice = GetNumberInput();
			if (menuChoice != null)
			{
				switch (menuChoice)
				{
					case 1:
						HandleConvert();
						break;
					case 2:
						PrintAliasMenu();
						break; 
					case 3:
						PrintQuantitiesMenu();
						break;
					case 4:
						return false;
					default:
						break;
				}
			}
			return true;
		}

	


		private void PrintQuantitiesMenu()
		{
			Console.WriteLine("Quantities");
			Console.WriteLine("1. List all quantity");
			Console.WriteLine("2. Add custom quantity");
			Console.WriteLine("3. Add unit to custom quantity");
			Console.WriteLine("4. List all units of custom quantity");
			Console.WriteLine("5. Delete unit from custom quantity");
			Console.WriteLine("6. Delete custom quantity");
			int? menuChoice = GetNumberInput();
			if (menuChoice != null)
			{
				switch (menuChoice)
				{
					case 1:
						PrintQuantities();
						break;
					case 2:
						AddCustomQuantity();
						break;
					case 3:
						AddUnitToCustomQuantity();
						break;
					case 4:
						ListUnitsForCustomQuantity();
						break;
					case 5:
						DeleteUnitFromCustomQuantity();
						break;
					case 6:
						DeleteCustomQuantity();
						break;
					default:
						break;
				}
			}
		}

		

		private void PrintAliasMenu()
		{
			Console.WriteLine("Aliases");
			Console.WriteLine("1. List alias for quantity");
			Console.WriteLine("2. Add alias for quantity");
			Console.WriteLine("3. Delete alias for quantities");
			int? menuChoice = GetNumberInput();
			if (menuChoice != null)
			{
				switch (menuChoice)
				{
					case 1:
						PrintAlias();
						break;
					case 2:
						AddAlias();
						break;
					case 3:
						DeleteAlias();
						break;
					case 4:
					default:
						break;
				}
			}
		}

		private void PrintQuantities()
		{
			List<string> quantities = Converter.ListQuantities();
			foreach (var quantity in quantities)
			{
				Console.WriteLine("Our quantities: " + quantity);
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		// - custom quantity
		private void AddCustomQuantity()
		{
			Console.WriteLine("Type the name of the new quantity:");
			string? quantity = Console.ReadLine();
			if (quantity != null)
			{
				Converter.AddNewQuantity(quantity);
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		private void AddUnitToCustomQuantity()
		{
			Console.WriteLine("Type the name of the custom quantity:");
			string? quantity = Console.ReadLine();
			if (quantity != null)
			{
				Console.WriteLine($"Type in the unit to add to {quantity}:");
				string? unit = Console.ReadLine()?.ToLower();
				if (unit != null)
				{
					Converter.AddUnitToQuantity(unit, quantity);
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		private void ListUnitsForCustomQuantity()
		{
			Console.WriteLine("Type the name of the custom quantity:");
			string? quantity = Console.ReadLine();
			if (quantity != null)
			{
				List<string>? unitList = Converter.ListUnitsForCustomQuantity(quantity);
				if (unitList != null)
				{
					Console.WriteLine($"Units in {quantity}: ");
					foreach (var unit in unitList)
					{
						Console.Write($"{unit}, ");
					}
					Console.WriteLine("\n");
				}
				else
				{
					Console.WriteLine($"Didn't find any units in {quantity}");
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		private void DeleteUnitFromCustomQuantity()
		{
			Console.WriteLine("Type the name of the custom quantity:");
			string? quantity = Console.ReadLine();
			if (quantity != null)
			{
				Console.WriteLine($"Type in the unit to remove from {quantity}:");
				string? unit = Console.ReadLine()?.ToLower();
				if (unit != null)
				{
					Converter.DeleteUnitFromQuantity(unit, quantity);
					Console.WriteLine($"Deleted {unit} from {quantity}");
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		private void DeleteCustomQuantity()
		{
			Console.WriteLine("Type the name of the custom quantity:");
			string? quantity = Console.ReadLine();
			if (quantity != null)
			{
				Converter.DeleteCustomQuantity(quantity);
				Console.WriteLine($"Deleted custom quantity named {quantity}");
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		

		private void PrintAlias()
		{
			Console.WriteLine("Type the unit to list aliases for:");
			string? unit = Console.ReadLine()?.ToLower();
			if (unit != null)
			{
				List<string>? aliases = Converter.ListAliasForUnit(unit);
				if (aliases != null)
				{
					Console.WriteLine($"Alias for {unit}: ");
					foreach (var alias in aliases)
					{
						Console.Write($"{alias}, ");
					}
					Console.WriteLine("\n");
				} else
				{
					Console.WriteLine($"Didn't find any alias for {unit}");
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}


		private void AddAlias()
		{
			Console.WriteLine("Type the unit to add aliases for:");
			string? unit = Console.ReadLine()?.ToLower();
			if (unit != null)
			{
				Console.WriteLine($"Type in the aliases for {unit}:");
				string? alias = Console.ReadLine()?.ToLower();
				if(alias != null )
				{
					Converter.AddAlias(unit, alias);
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}

		private void DeleteAlias()
		{
			Console.WriteLine("Type the unit to remove aliases from:");
			string? unit = Console.ReadLine()?.ToLower();
			if (unit != null)
			{
				Console.WriteLine($"Type in the aliases to remove from {unit}:");
				string? alias = Console.ReadLine()?.ToLower();
				if (alias != null)
				{
					Converter.DeleteAlias(unit, alias);
					Console.WriteLine($"Delete {alias} from list of aliases for unit {unit}");
				}
			}
			Console.WriteLine("Type any key to continue");
			Console.ReadLine();
		}


		private void HandleConvert()
		{
			Console.WriteLine("Type in number to convert from: ");
			double? number1 = GetFloatInput();
			Console.WriteLine("Type in unit of number: ");
			string? unitFrom = Console.ReadLine()?.ToLower();
			Console.WriteLine("Type in unit to convert to: ");
			string? unitTo = Console.ReadLine()?.ToLower();
			if (number1 != null && unitFrom != null && unitTo != null)
			{
				var valWithUnit = Converter.Convert((double)number1, unitFrom, unitTo);
				if(valWithUnit != null)
				{
					Console.WriteLine($"{number1}{unitFrom} is converted to {valWithUnit.Value}{valWithUnit.Unit}");
				}
					Console.ReadLine();
			} else
			{
				Console.WriteLine("Please type in valid values");
			}
		}

		


		private int? GetNumberInput()
		{
			string? input = Console.ReadLine();
			if (input != null)
			{
				try
				{
					int menuChoise = Int32.Parse(input);
					return menuChoise;
					
				}
				catch (Exception)
				{

					return null;
				}
				
			}
			return null;
		}

		private double? GetFloatInput()
		{
			string? input = Console.ReadLine();
			if (input != null)
			{
				try
				{
					double value = Double.Parse(input);
					return value;

				}
				catch (Exception)
				{

					return null;
				}

			}
			return null;
		}
	}
}
