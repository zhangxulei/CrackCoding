using System;

namespace CrackCoding
{
	public class _9_1
	{
		public _9_1 ()
		{
		}

		public static int WaysCount (int n)
		{
			if (n < 0) {
				return 0;
			}

			if (n == 0) {
				return 1;
			}

			return WaysCount (n - 1) + WaysCount (n - 2) + WaysCount (n - 3);
		}

		public static int WaysCount (int n, int[] map)
		{
			if (n < 0) {
				return 0;
			}

			if (n == 0) {
				return 1;
			}

			if (map [n] > 0) {
				return map [n];
			}

			map [n] = WaysCount (n - 1, map) + WaysCount (n - 2, map) + WaysCount (n - 3, map);

			return map [n];
		}
	}
}

