using System;

namespace CrackCoding
{
	public class _1_7
	{
		public _1_7 ()
		{
		}

		public static int[,] CleanZeroMatrix(int[,] matrix, int m, int n){
			bool[] rowZero = new bool[m]; 
			bool[] columnZero = new bool[n];

			for (int i = 0; i < m; i++) {
				for (int j = 0; j < n; j++) {
					if (matrix[i,j]==0) {
						rowZero [i] = true;
						columnZero [j] = true;
					}
				}
			}

			for (int i = 0; i < m; i++) {
				for (int j = 0; j < n; j++) {
					if (rowZero[i]==true || columnZero[j]==true) {
						matrix [i,j] = 0;
					}
				}
			}

			return matrix;
		}
	}
}

