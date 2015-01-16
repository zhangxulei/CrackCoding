using System;

namespace CrackCoding
{
	public class _2_5
	{
		public _2_5 ()
		{
		}

		public static Node AddNodeList (Node node1, Node node2)
		{
			return AddNodeListFunction (node1, node2, 0);
		}

		static Node AddNodeListFunction (Node node1, Node node2, int carry)
		{
			if (node1 == null && node2 == null) {
				return null;
			}

			int sum = 0;
			if (node1 != null) {
				sum += node1.Data;
			}

			if (node2 != null) {
				sum += node2.Data;
			}

			sum += carry;

			Node node = new Node (sum % 10);
		    
			Node fullResult = AddNodeListFunction ((node1 == null ? null : node1.Next),
				                  (node2 == null ? null : node2.Next), sum / 10);

			node.Next = fullResult;

			return node;
		}
	}
}

