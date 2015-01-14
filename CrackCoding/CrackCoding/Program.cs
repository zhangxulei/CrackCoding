using System;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please Input A String:");

			string testString;
			testString = Console.ReadLine ();

			bool isAllDifferent = CrackCoding._1_1.IsAllDifferent (testString);

			Console.WriteLine (isAllDifferent.ToString ());
		}
	}
}
