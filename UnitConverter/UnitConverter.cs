using System.Xml.Serialization;
using System.Xml;

namespace unit_conversion.Models
{
	public class ValueWithUnit : unit_converter.UserInput
	{
		public double Value { get; set; }
		public string? Unit { get; set; }
		public string? Annotation { get; set; }
	}

	public class UnitConverter
    {
		public Dictionary<string, UnitOfMeasureDictionaryUnitOfMeasure> Units { get; set; } = new Dictionary<string, UnitOfMeasureDictionaryUnitOfMeasure>();
        public Dictionary<string, List<string>> Quantities { get; set; } = new Dictionary<string, List<string>>();
		public Dictionary<string, List<string>> CustomQuantities { get; set; } = new Dictionary<string, List<string>>();
		public List<string> Dimensions { get; set; } = new List<string>();
        public Dictionary<string, List<string>> Aliases { get; set; } = new Dictionary<string, List<string>>();


		public UnitConverter(string fileToParse = @"POSC.xml")
		{
			ParseXML(fileToParse);
		}

       // - Aliases -

		public void AddNewQuantity(string quantityName)
		{
			// check if it already exist
			if (CustomQuantities.ContainsKey(quantityName))
			{
				return;
			}
			CustomQuantities.Add(quantityName, new List<string>());
		}

		public void AddUnitToQuantity(string unitName, string quantityName)
		{
			var unit = Units.GetValueOrDefault(unitName);
			var quantity = CustomQuantities.GetValueOrDefault(quantityName);
			if (unit == null || quantity == null)
			{
				return;
			}
			quantity.Add(unitName);
		}

		public void DeleteUnitFromQuantity(string unitName, string quantityName)
		{
			var unit = Units.GetValueOrDefault(unitName);
			var quantity = CustomQuantities.GetValueOrDefault(quantityName);
			if (unit == null || quantity == null)
			{
				return;
			}
			quantity.Remove(unitName);
		}

		public void DeleteCustomQuantity(string quantityName)
		{
			// check if it already exist
			if (!CustomQuantities.ContainsKey(quantityName))
			{
				return;
			}
			CustomQuantities.Remove(quantityName);
		}

		public void AddAlias(string unit, string alias)
		{
			List<string> aliasesForUnit;
			if (Aliases.TryGetValue(unit, out aliasesForUnit))
			{
				aliasesForUnit.Add(alias);
			}
			else
			{
				aliasesForUnit = new List<string>
				{
					alias
				};
				Aliases.Add(unit, aliasesForUnit);
			}
		}

		public void DeleteAlias(string unit, string alias)
        {
         	List<string> aliasesForUnit;
			if (Aliases.TryGetValue(unit, out aliasesForUnit))
			{
				aliasesForUnit.Remove(alias);
			}
		}

		public List<string>? ListAliasForUnit(string unit)
		{
			try
			{
				return Aliases.GetValueOrDefault(unit);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public List<string> ListDimensions() { return Dimensions; }
        public List<string> ListQuantities() { return Quantities.Keys.ToList(); }
        public List<string>? ListUnitsForQuantity(string quantity)
        {
            try
            {
				return Quantities.GetValueOrDefault(quantity);
        	}
            catch (Exception)
            {

                throw;
            }
        }

		public List<string>? ListUnitsForCustomQuantity(string quantity)
		{
			try
			{
				return CustomQuantities.GetValueOrDefault(quantity);
			}
			catch (Exception)
			{

				throw;
			}
		}


		public ValueWithUnit Convert(double value, string from, string to)
        {
            var fromUnit = Units.GetValueOrDefault(from);
			var toUnit = Units.GetValueOrDefault(to);
            if (fromUnit == null || toUnit == null)
            {
                return null;
            }
            double convertedValue = value;
            var baseUnit = (UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit)(GetGivenObject(fromUnit, ItemsChoiceType.ConversionToBaseUnit));
			if (baseUnit != null)
            {
                convertedValue = ConversionToBase(baseUnit, convertedValue);
				Convert(convertedValue, baseUnit.baseUnit, to);
            }
            
            var toUnitBase = (UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit)(GetGivenObject(toUnit, ItemsChoiceType.ConversionToBaseUnit));
			if (toUnitBase != null)
			{
				convertedValue = ConversionFromBase(toUnitBase, convertedValue);
			}

			var unitBase = (UnitOfMeasureDictionaryUnitOfMeasureSameUnit)(GetGivenObject(toUnit, ItemsChoiceType.SameUnit));
            string uom = unitBase.uom ?? to;    // if we don't find the uom use the given value
 			ValueWithUnit converted = new ValueWithUnit{ Value = convertedValue, Unit = uom, Annotation = toUnit.annotation };
            return converted;
		}

        private double ConversionToBase(UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit baseUnit, double value)
        {
			double convertedValue = value;
            if (baseUnit.FactorSpecified)
			{
				convertedValue *= baseUnit.Factor;
			}
			else if (baseUnit.Fraction != null)
			{
				convertedValue *= baseUnit.Fraction.Numerator / (double)baseUnit.Fraction.Denominator;
			}
			else if (baseUnit.Formula != null)
			{
				convertedValue = ((double)baseUnit.Formula.A + value * (double)baseUnit.Formula.B) / ((double)baseUnit.Formula.C + value * (double)baseUnit.Formula.D);
			}
            return convertedValue;
		}

        private double ConversionFromBase(UnitOfMeasureDictionaryUnitOfMeasureConversionToBaseUnit baseUnit, double value)
        {
			double convertedValue = value;
			if (baseUnit.FactorSpecified)
			{
				convertedValue /= baseUnit.Factor;
			}
			else if (baseUnit.Fraction != null)
			{
				convertedValue *= (double)baseUnit.Fraction.Denominator / baseUnit.Fraction.Numerator;
			}

			else if (baseUnit.Formula != null)
			{
				convertedValue = ((double)baseUnit.Formula.A - convertedValue * (double)baseUnit.Formula.C) / (convertedValue * (double)baseUnit.Formula.D - (double)baseUnit.Formula.B);
			}
            return convertedValue;
		}


		private object GetGivenObject(UnitOfMeasureDictionaryUnitOfMeasure unit, ItemsChoiceType choiceType)
		{
			var unitObject = unit.Items;
			var objectElementType = unit.ItemsElementName;
			for (int i = 0; i < unitObject.Length; i++)
			{
				if (objectElementType[i] == choiceType)
				{
					return unitObject[i];
				}
			}
			return null;
		}


		private void ParseXML(string fileToParse = @"..\POSC.xml")
		{
			using (var sreader = new StringReader(File.ReadAllText(fileToParse)))
			using (var reader = XmlReader.Create(sreader))
			{
				var serializer = new XmlSerializer(typeof(UnitOfMeasureDictionary));
				var test = (UnitOfMeasureDictionary)serializer.Deserialize(reader);
				//Console.WriteLine(test.DocumentInformation);
				//Console.WriteLine(test.UnitsDefinition);
				//foreach (var item in test.UnitsDefinition)
				//{
				//	Console.WriteLine(((uint)item.ItemsElementName.Length));
				//}

				var units = test.UnitsDefinition;
				foreach (var unit in units)
				{
					Units.Add(unit.id, unit);
					//Console.WriteLine($"Da units pls: {unit.annotation} {unit.id} {unit.Items.Length}");
					var unitObject = unit.Items;
					var objectElementType = unit.ItemsElementName;
					for (int i = 0; i < unitObject.Length; i++)
					{
						string key = unitObject[i].ToString();
						if (objectElementType[i] == ItemsChoiceType.QuantityType)
						{
							//Console.WriteLine($"ObjectType: {objectElementType[i]}");
							//Console.WriteLine($"Object: {unitObject[i]}");

							List<string> quantity;
							if (Quantities.TryGetValue(key, out quantity))
							{
								quantity.Add(unit.id);
							}
							else
							{
								quantity = new List<string>
								{
									unit.id
								};
								Quantities.Add(key, quantity);
							}
						}
						if (objectElementType[i] == ItemsChoiceType.DimensionalClass)
						{
							if (!Dimensions.Contains(key))
							{
								Dimensions.Add(key);
							}
						}
					}
				}
			}
		}
	}
}


    