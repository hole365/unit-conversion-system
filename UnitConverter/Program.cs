// See https://aka.ms/new-console-template for more information
using unit_conversion.Models;
using unit_converter;

Console.WriteLine("Unit Converter");

UnitConverter unitConverter = new UnitConverter(@"..\..\..\a.xml");


List<string> quantities = unitConverter.ListQuantities();
foreach (var quantity in quantities)
{
	Console.WriteLine("Our quantities: " + quantity);
}


UserInput ui = new UserInput();
ui.PrintMenu();
