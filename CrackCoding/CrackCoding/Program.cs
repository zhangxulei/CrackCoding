using System;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Please Input A String:");
//
//			string testString1;
//			testString1 = Console.ReadLine ();
//		    
//			string testString2 = _1_5.CompressString(testString1);
//
//			Console.WriteLine (testString2.ToString ());

			int[,] matrix = new int[4,5] {
				{1,2,3,4,5},
				{5,4,0,2,1},
				{6,7,8,9,10},
				{0,9,8,7,6},
			};

			int[,] rotatedMap = _1_7.CleanZeroMatrix (matrix,4,5);

			Console.WriteLine (rotatedMap.ToString ());
		}
	}
}
