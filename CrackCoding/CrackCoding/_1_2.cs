using System;
using System.Text;

namespace CrackCoding
{
	public class _1_2
	{
		public _1_2 ()
		{
		}

		public static string Reverse(string str){

			int firstIndex = 0;
			int lastIndex = str.Length - 1;

			StringBuilder strBuilder = new StringBuilder (str);

			while (firstIndex < lastIndex) {
				char temp = str [firstIndex];

				strBuilder.Remove (firstIndex, 1);
				strBuilder.Insert (firstIndex, str [lastIndex]);

				strBuilder.Remove (lastIndex, 1);
				strBuilder.Insert (lastIndex, temp);

				firstIndex++;
				lastIndex--;
			}
			return strBuilder.ToString ();
		}
	}
}

