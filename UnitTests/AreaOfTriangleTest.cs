using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTask;

namespace UnitTests
{
	[TestFixture]
	public class AreaOfTriangleTest
	{
		[Test]
		public void Default()
		{
            Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(5, 6, 3), 4), 7.4833);
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(5, 6, 10), 4), 11.399);
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(8, 6, 3), 4), 7.6444);
		}

		[Test]
		public void NotRoundNumbers()
		{
			Assert.AreEqual(Math.Round(Utils.AreaOfTriangle(5.5, 6.1, 3.3), 4), 9.0217);
		}

		[Test]
		public void ImpossibleTriangle()
		{
			Assert.Throws(typeof(ArgumentException), delegate { Utils.AreaOfTriangle(5, 6, 12); });
			Assert.Throws(typeof(ArgumentException), delegate { Utils.AreaOfTriangle(5, 20, 10); });
			Assert.Throws(typeof(ArgumentException), delegate { Utils.AreaOfTriangle(5, 3, 1); });
		}

		[Test]
		public void NegativeNumbers()
		{
			Assert.AreEqual(Utils.AreaOfTriangle(-9, 6, 3), 0);
			Assert.AreEqual(Utils.AreaOfTriangle(9, 6, -3), 0);
		}
	}
}
