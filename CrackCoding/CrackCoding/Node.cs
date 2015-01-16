using System;

namespace CrackCoding
{
	public class Node
	{
		int data;

		public Node Next;

		public Node (int d)
		{
			data = d;

		}

		public int Data {
			get {
				return data;
			}
			set {
				data = value;
			}
		}
	}
}

