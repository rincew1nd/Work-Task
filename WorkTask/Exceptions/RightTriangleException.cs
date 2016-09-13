using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Exceptions
{
	public class RightTriangleException : Exception
	{
		public RightTriangleException()
		{
		}

		public RightTriangleException(string message)
        : base(message)
		{
		}
	}
}
