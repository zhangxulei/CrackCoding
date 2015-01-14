using System;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please Input A String1:");

			string testString1;
			testString1 = Console.ReadLine ();

			Console.WriteLine ("Please Input A String2:");
			string testString2;
			testString2 = Console.ReadLine ();

			bool canResort = _1_3.CanReSort (testString1, testString2);

			Console.WriteLine (canResort.ToString ());

		}
	}
}
