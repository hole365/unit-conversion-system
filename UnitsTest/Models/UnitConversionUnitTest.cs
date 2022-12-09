using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_conversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_conversion.Models.Tests
{
	[TestClass()]
	public class UnitConversionUnitTest
	{

		private readonly UnitConverter _unitConverter;
		public UnitConversionUnitTest()
		{
			_unitConverter = new UnitConverter(@"..\..\..\..\POSC.xml");
		}
		public UnitConverter Converter { get { return _unitConverter; } private set {; } }


		[TestMethod()]
		public void ListAliasForUnitTest()
		{
			Converter.AddAlias("m", "meter");
			Converter.AddAlias("m", "metre");
			Converter.AddAlias("m", "metere");
			//            //Console.WriteLine($"found the type meter: {type1}");

			//            Converter.AddAlias("m", "metre");
			//            //Console.WriteLine($"found the type metre: {type2}");

			//            //var type3 = Converter.AddAlias("m", "metere");
			//            //Console.WriteLine($"found the type metere: {type3}");


			//Console.WriteLine($"Number of Alises for unit meter: {Converter.ListAliasForUnit("m")}");

			//            List<string> unitInLength = Converter.ListAliasForUnit("length");
			//            foreach (var u in unitInLength)
			//            {
			//                Console.WriteLine($"Length units: {u.ToString()}");
			//            }

			Assert.Fail();
		}

		[TestMethod()]
		public void ListUnitsForQuantityTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ConvertTest()
		{
			var convertedU0 = Converter.Convert(100, "m", "mm");
			//Console.WriteLine($"Value converted: {convertedU0.Value} {convertedU0.Unit} {convertedU0.Annotation}");
			Assert.AreEqual(100000, convertedU0.Value);
			Assert.AreEqual("mm", convertedU0.Unit);
			Assert.AreEqual("mm", convertedU0.Annotation);
			//var converted = Converter.Convert(102e-6, "in", "cm");
			//Console.WriteLine($"Value converted: {converted.Value} {converted.Unit} {converted.Annotation}");

			//var convertedU3 = Converter.Convert(10, "degF", "degC");
			//Console.WriteLine($"Value converted: {convertedU3.Value} {convertedU3.Unit} {convertedU3.Annotation}");
		}

		[TestMethod()]
		public void AddNewQuantityTest()
		{
			// Add a new quantity
			Converter.AddNewQuantity("myQuantity");
			var quantity = Converter.CustomQuantities.GetValueOrDefault("myQuantity");
			Assert.IsNotNull(quantity);

			// Add a few units to our quantity
			Converter.AddUnitToQuantity("m", "myQuantity");
			Converter.AddUnitToQuantity("in", "myQuantity");
			quantity = Converter.CustomQuantities.GetValueOrDefault("myQuantity");
			Assert.IsNotNull(quantity);
			Assert.AreEqual(2, quantity.Count);
			Assert.AreEqual("m", quantity[0]);
			Assert.AreEqual("in", quantity[1]);

			// Test delete
			Converter.DeleteUnitFromQuantity("m", "myQuantity");
			quantity = Converter.CustomQuantities.GetValueOrDefault("myQuantity");
			Assert.IsNotNull(quantity);
			Assert.AreEqual(1, quantity.Count);
			Assert.AreEqual("in", quantity[0]);

			Converter.DeleteCustomQuantity("myQuantity");
			quantity = Converter.CustomQuantities.GetValueOrDefault("myQuantity");
			Assert.IsNull(quantity);
		}
	}
}