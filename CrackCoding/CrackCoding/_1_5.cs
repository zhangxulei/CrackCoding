using System;
using System.Text;

namespace CrackCoding
{
	public class _1_5
	{
		public _1_5 ()
		{
		}

		public static string CompressString (string str)
		{
			if (str.Length <= 0) {
				return str;
			}

			System.Text.StringBuilder compressString = new StringBuilder ();
			int charCount = 0;
			char keyChar = str [0];

			foreach (var strChar in str) {
				if (strChar == keyChar) {
					charCount++;
				} else {
					compressString.Append (keyChar);
					compressString.Append (charCount);
					keyChar = strChar;
					charCount = 1;
				}
			}
			compressString.Append (keyChar);
			compressString.Append (charCount);

			if (compressString.Length >= str.Length) {
				return str;
			}

			return compressString.ToString ();
		}
	}
}

