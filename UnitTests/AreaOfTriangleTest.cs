using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Exceptions;
using WorkTask;

namespace UnitTests
{
	[TestFixture]
	public class AreaOfTriangleTest
	{

		[Test]
		public void PositiveCases()
		{
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(3, 5, Math.Sqrt(Math.Pow(3,2) + Math.Pow(5,2))), 4), 7.5);
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(3, 4, 5), 4), 6);
		}

		[Test]
		public void ImpossibleTriangle()
		{
			Assert.Throws(typeof(ImpossibleTriangleException), delegate { Utils.AreaOfTriangle(5, 6, 12); });
			Assert.Throws(typeof(ImpossibleTriangleException), delegate { Utils.AreaOfTriangle(5, 20, 10); });
			Assert.Throws(typeof(ImpossibleTriangleException), delegate { Utils.AreaOfTriangle(5, 3, 1); });
		}

		[Test]
		public void NotRightAngledTriangles()
		{
			Assert.Throws(typeof(RightTriangleException), delegate { Utils.AreaOfTriangle(5, 6, 3); });
			Assert.Throws(typeof(RightTriangleException), delegate { Utils.AreaOfTriangle(5, 6, 10); });
			Assert.Throws(typeof(RightTriangleException), delegate { Utils.AreaOfTriangle(8, 6, 3); });
		}

		[Test]
		public void NegativeNumbers()
		{
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(3, -4, 5), 4), 6);
		}
	}
}
