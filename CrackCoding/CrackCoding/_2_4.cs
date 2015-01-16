using System;

namespace CrackCoding
{
	public class _2_4
	{
		public _2_4 ()
		{
		}

		public static Node MoveNodeByX (Node head, int x)
		{
			Node smallNode = null;
			Node bigNode = null;

			while (head != null) {
				if (head.Data < x) {
					Node newNode = new Node (head.Data);
					newNode.Next = smallNode;
					smallNode = newNode;
				} else {
					Node newNode = new Node (head.Data);
					newNode.Next = bigNode;
					bigNode = newNode;
				}
				head = head.Next;
			}

			Node smallEndNode = smallNode;
			while (smallEndNode.Next != null) {
				smallEndNode = smallEndNode.Next;
			}

			smallEndNode.Next = bigNode;

			return smallNode;
		}
	}
}

