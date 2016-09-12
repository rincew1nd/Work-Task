using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				throw new ArgumentException("Impossible triangle. One side larger then sum of others.");

			var halfArea = (a + b + c) / 2;
			return Math.Sqrt(halfArea * (halfArea - sA[0]) * (halfArea - sA[1]) * (halfArea - sA[2]));
		}
    }
}
