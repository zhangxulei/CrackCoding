using System;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
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
	
			Node node = _2_2.FindNodeInList (node1, 3);

			Console.WriteLine (node.Data);
		}
	}
}
