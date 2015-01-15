using System;

namespace CrackCoding
{
	public class _1_6
	{
		public _1_6 ()
		{
		}

		public static int[,] RotateMatrix (int[,]matrix, int length)
		{
			for (int layer = 0; layer < length / 2; layer++) {
				int firstIndex = layer;
				int lastIndex = length - layer - 1;
				for (int index = firstIndex; index < lastIndex; index++) {
					int temp = matrix [layer,index];
					matrix [layer,index] = matrix [length - index - 1,layer];
					matrix [length - index - 1,layer] = matrix [length - layer - 1,length - index - 1];
					matrix [length - layer - 1,length - index - 1] = matrix [index,length - layer - 1];
					matrix [index,length - layer - 1] = temp;
				}
			}
				
			return matrix;
		}
	}
}

