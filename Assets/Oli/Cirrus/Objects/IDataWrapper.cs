using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirrus.Objects
{
	public interface IDataWrapper<TData>
	{
		TData Data { get; set; }
	}
}
