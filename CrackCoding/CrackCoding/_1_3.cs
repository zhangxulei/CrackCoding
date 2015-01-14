using System;

namespace CrackCoding
{
	public class _1_3
	{
		public _1_3 ()
		{
		}

		public static bool CanReSort (string str1, string str2)
		{
			if (str1.Length != str2.Length) {
				return false;
			}

			int[] lettersCount = new int[256];

			foreach (var str1Char in str1) {
				int str1CharKey = (int)str1Char;
				lettersCount [str1CharKey]++;
			}

			foreach (var str2Char in str2) {
				int str2CharKey = (int)str2Char;
				lettersCount [str2CharKey]--;
				if (lettersCount [str2CharKey] < 0) {
					return false;
				}
			}
			return true;
		}
	}
}

