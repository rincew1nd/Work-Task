using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Exceptions;

namespace WorkTask
{
    public static class Utils
    {
		/// <summary>
		/// Calculate area of triangle by 3 sides
		/// </summary>
		/// <param name="a">Side 1</param>
		/// <param name="b">Side 2</param>
		/// <param name="c">Side 3</param>
		/// <returns>Area of triangle</returns>
		public static double AreaOfTriangle(double a, double b, double c)
		{
			var sA = new List<double>() { a, b, c }
				.Select(e => { e = Math.Abs(e); return e; })
				.OrderBy(e => e)
				.ToList();

			if (sA[2] > sA[0] + sA[1])
				throw new ImpossibleTriangleException("Impossible triangle. One side larger then sum of others.");

			var angles = new double[3];
			angles[0] = (Math.Pow(sA[0], 2) + Math.Pow(sA[1], 2) - Math.Pow(sA[2], 2)) / (2 * sA[0] * sA[1]);
			angles[1] = (Math.Pow(sA[1], 2) + Math.Pow(sA[2], 2) - Math.Pow(sA[0], 2)) / (2 * sA[1] * sA[2]);
			angles[2] = (Math.Pow(sA[2], 2) + Math.Pow(sA[0], 2) - Math.Pow(sA[1], 2)) / (2 * sA[2] * sA[0]);
			if (!angles.Any(n => n == 0))
				throw new RightTriangleException("Triangle is not right-angled.");
			
			var halfArea = (sA[0] + sA[1] + sA[2]) / 2;
			return Math.Sqrt(halfArea * (halfArea - sA[0]) * (halfArea - sA[1]) * (halfArea - sA[2]));
		}
    }
}
