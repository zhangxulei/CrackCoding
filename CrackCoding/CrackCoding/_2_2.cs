using System;

namespace CrackCoding
{
	public class _2_2
	{
		public _2_2 ()
		{
		}

		public static Node FindNodeInList (Node head, int k)
		{
			int i = 0;
			return FindNodeInListFuction (head, k, ref i);
		}

		static Node FindNodeInListFuction (Node head, int k, ref int i)
		{
			if (head == null) {
				return null;
			}

			Node node = FindNodeInListFuction (head.Next, k, ref i);
			i++;
			if (i == k) {
				return head;
			} else {
				return node;
			}
		}
	}
}

