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

			Node node1 = new Node (1);

			Node node2 = new Node (2);
			node1.Next = node2;

			Node node3 = new Node (3);
			node2.Next = node3;

			Node node4 = new Node (2);
			node3.Next = node4;

			Node node5 = new Node (5);
			node4.Next = node5;

			Node node6 = new Node (6);
			node5.Next = node6;

			Node node7 = new Node (1);
			node6.Next = node7;
		
			_2_1.RemoveDuplicateNode (node1);

			Node node = node1;
			while (node!=null) {
				Console.WriteLine (node.Data);
				node = node.Next;
			}
		}
	}
}
