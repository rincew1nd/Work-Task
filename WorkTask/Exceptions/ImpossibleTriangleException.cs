using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Exceptions
{
	public class ImpossibleTriangleException : Exception
	{
		public ImpossibleTriangleException()
		{
		}

		public ImpossibleTriangleException(string message)
        : base(message)
		{
		}
	}
}
