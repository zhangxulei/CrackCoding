using System;

namespace CrackCoding
{
	public class _1_4
	{
		public _1_4 ()
		{
		}

		public static string ReplaceBlank (char[] strArray, int length)
		{
			int blankCount = 0;
			foreach (var strChar in strArray) {
				if (strChar == ' ') {
					blankCount++;
				}
			}

			int newLength = length + 2 * blankCount;
			char[] newStrArray = new char[newLength];

			for (int i = length - 1; i >= 0; i--) {
				if (strArray [i] == ' ') {
					newStrArray [newLength - 1] = '0';
					newLength--;
					newStrArray [newLength - 1] = '2';
					newLength--;
					newStrArray [newLength - 1] = '%';
					newLength--;
				} else {
					newStrArray [newLength - 1] = strArray [i];
					newLength--;
				}
			}
			return new string (newStrArray);
		}
	}
}

