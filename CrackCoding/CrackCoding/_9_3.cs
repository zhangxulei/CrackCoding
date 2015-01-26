using System;

namespace CrackCoding
{
	public class _9_3
	{
		public _9_3 ()
		{
		}

		public int FindMagicIndex (int[] array, int startIndex, int endIndex)
		{
			if (startIndex < 0 || endIndex >= array.Length || startIndex > endIndex) {
				return -1;
			}

			int midIndex = (startIndex + endIndex) / 2;

			int mid = array [midIndex];

			if (mid == midIndex) {
				return midIndex;
			}

			int leftEnd = Math.Min (midIndex - 1, mid);
			int leftIndex = FindMagicIndex (array, startIndex, leftEnd);

			if (leftIndex >= 0) {
				return leftIndex;
			}

			int rightStart = Math.Max (midIndex + 1, mid);
			int rightIndex = FindMagicIndex (array, rightStart, endIndex);

			if (rightIndex >= 0) {
				return rightIndex;
			}
		}
	}
}

