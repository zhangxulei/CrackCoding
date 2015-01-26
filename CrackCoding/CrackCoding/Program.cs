using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace CrackCoding
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x = 2;
			int y = 2;

			Point3D pt = new Point3D (0, 0, 0);
			List<Point3D> path = new List<Point3D> ();

			int count = _9_2.MoveCounts (x, y, pt, path);

			foreach (var pathPt in path) {
				Console.WriteLine (pathPt.X.ToString () + "," + pathPt.Y.ToString ());
			}
		}
	}
}
