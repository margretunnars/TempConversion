using System;

namespace TConv
{
	class TempConv
	{
		public static void Main(string[] args)
		{
			double fahrTemp, celTemp;
			string input;

			Console.WriteLine("Enter a temperature in decrees Celsius");
			input = Console.ReadLine();
			celTemp = double.Parse(input);

			fahrTemp = (celTemp + 32.0) * 9.0 / 5.0;

			Console.WriteLine("The temperature in degrees is " + fahrTemp + " in degrees Fahrenheit");



		}
	}
}
