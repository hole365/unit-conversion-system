using Microsoft.AspNetCore.Mvc;
using unit_conversion.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitConversionAPI.Controllers
{
	//[Route("api/[controller]")]
	[Route("api")]
	[ApiController]
	public class ConversionController : ControllerBase
	{
		private readonly UnitConverter _unitConverter;
		public ConversionController()
		{
			_unitConverter = new UnitConverter(@"..\a.xml");
		}
		public UnitConverter Converter { get { return _unitConverter; } private set {; } }


		// - convert -



		// - quantity -

		[Route("quantity")]
		[HttpGet]
		public IEnumerable<string> GetQuantities()
		{
			return Converter.ListQuantities();
		}


		[Route("unit/{quantity}")]
		[HttpGet]
		public IEnumerable<string> Get(string quantity)
		{
			return Converter.ListUnitsForQuantity(quantity);
		}

		// - unit -

		[Route("unit/base")]
		[HttpGet]
		public IEnumerable<string> GetDimensions()
		{
			return Converter.ListDimensions();
		}

		[Route("unit")]
		[HttpGet]
		public IEnumerable<string> GetUnitsForQuantity()
		{
			return Converter.ListDimensions();
		}

		// - Custom quantity - 
		[Route("quantity/custom")]
		[HttpPost]
		public void AddNewQuantity([FromBody] string quantity)
		{
			Converter.AddNewQuantity(quantity);
		}

		[Route("quantity/custom/{quantity}")]
		[HttpPut]
		public void AddUnitToQuantity(string quantity, [FromBody] string unit)
		{
			Converter.AddUnitToQuantity(quantity, unit);
		}

		[Route("quantity/custom/{quantityName}")]
		[HttpGet]
		public void GetUnitsForQuantity(string quantityName)
		{
			Converter.ListUnitsForCustomQuantity(quantityName);
		}

		[Route("quantity/custom/{quantityName}")]
		[HttpDelete]
		public void Delete(string quantityName)
		{
			Converter.DeleteCustomQuantity(quantityName);
		}

		[Route("quantity/custom/{quantity}/{unit}")]
		[HttpDelete]
		public void DeleteUnitFromQuantity(string quantityName, string unit)
		{
			Converter.DeleteUnitFromQuantity(quantityName, unit);
		}

		// - Alias -
		[Route("alias/{unit}")]
		[HttpGet]
		public IEnumerable<string> GetAliasesForUnit(string unit)
		{
			return Converter.ListAliasForUnit(unit);
		}

		[Route("alias/{unit}")]
		[HttpPut]
		public void AddAlias(string unit, [FromBody] string alias)
		{
			Converter.AddAlias(unit, alias);
		}
				
		[Route("alias/{unit}")]
		[HttpDelete]
		public void DeleteAlias(string unit, [FromBody] string alias)
		{
			Converter.DeleteAlias(unit, alias);
		}
	}
}

