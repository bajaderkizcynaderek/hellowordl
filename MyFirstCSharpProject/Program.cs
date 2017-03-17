using System;

namespace MyFirstCSharpProject
{
	class MainClass
	{
		public static void Main(string[] args) // fuck my args

		{
			string string1 = "  lorem Ipsum dolor amet sit    ";
			string string2 = " concecTuer aDAm *chomik* grzyb ";
			string trimm = string1.Trim();
			string szesc = string1.Trim().Substring(0, 6);

			Console.WriteLine($"Hello {string1}");
			Console.WriteLine (string1.ToUpper() + string2.ToLower());
			Console.WriteLine(trimm);
			Console.WriteLine (string1.Length+trimm.Length);
			Console.WriteLine ($"urywkiem tekstu jest-{szesc}-");

			//jestem glupi lol.

		}
	}
}
