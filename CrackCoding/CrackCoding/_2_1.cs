using System;

namespace CrackCoding
{
	public class _2_1
	{
		public _2_1 ()
		{
		}

		public static void RemoveDuplicateNode(Node node){
			Node currentNode = node;
			while (currentNode!=null) {
				Node compareNode = currentNode;
				while (compareNode.Next!=null) {
					if (currentNode.Data == compareNode.Next.Data) {
						compareNode.Next = compareNode.Next.Next;
					} else {
						compareNode = compareNode.Next;
					}
				}
				currentNode = currentNode.Next;
			}
		}
	}
}

