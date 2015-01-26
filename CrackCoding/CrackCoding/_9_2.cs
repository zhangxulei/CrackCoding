using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace CrackCoding
{
	public class _9_2
	{
		public _9_2 ()
		{
		}

		public static int MoveCounts (int x, int y, Point3D pt, List<Point3D> path)
		{
			if (x < 0 || y < 0) {
				return 0;
			}

			if (x == 0 && y == 0) {
				path.Add (new Point3D (0, 0, 0));
				return 1;
			}

			if (x == (int)pt.X && y == (int)pt.Y) {
				return 0;
			}

			Point3D pathPt = new Point3D (x, y, 0);
			path.Add (pathPt);

			return MoveCounts (x - 1, y, pt, path) + MoveCounts (x, y - 1, pt, path);
		}
	}
}

