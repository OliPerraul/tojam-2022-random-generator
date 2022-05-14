using Cirrus.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;
using Cirrus.Collections;
////using Cirrus.Events;
//using Event = Cirrus.Event;

namespace Cirrus.Unity.Objects
{
	public class DescComponent 
		: CustomMonoBehaviourBase
		, IIdentification
	{
		public HashSet<object> Metadata { get; set; }

		public uint Flags { get; set; }

		public int Id { get; set; } = (int)(object)-1;

		public Type Type { get; set; } = null;
	}
}
