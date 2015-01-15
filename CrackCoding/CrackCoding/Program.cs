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

			int[,] matrix = new int[5,5] {
				{1,2,3,4,5},
				{5,4,3,2,1},
				{6,7,8,9,0},
				{0,9,8,7,6},
				{10,11,12,13,14}
			};

			int[,] rotatedMap = _1_6.RotateMatrix (matrix, 5);

			Console.WriteLine (rotatedMap.ToString ());
		}
	}
}
