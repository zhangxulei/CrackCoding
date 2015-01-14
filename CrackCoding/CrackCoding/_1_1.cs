using System;

namespace CrackCoding
{
	public class _1_1
	{
		public _1_1 ()
		{
		}

		public static bool IsAllDifferent (string str1)
		{
			bool[] visable = new bool[256]; 
			foreach (var strChar in str1) {
				int strCharKey = (int)strChar;
				if (visable [strCharKey] == true) {
					return false;
				} else {
					visable [strCharKey] = true;
				}
			}
			return true;
		}
	}
}

