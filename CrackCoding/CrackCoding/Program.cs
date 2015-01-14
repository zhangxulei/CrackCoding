using System;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please Input A String:");

			string testString1;
			testString1 = Console.ReadLine ();
		    
			string testString2 = _1_4.ReplaceBlank (testString1.ToCharArray (), testString1.Length);

			Console.WriteLine (testString2.ToString ());
		}
	}
}
