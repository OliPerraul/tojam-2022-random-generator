using Cirrus.States;
using Cirrus.Unity.Objects;
using System;

namespace Cirrus.Unity.States
{
	public partial class StateComponentBase
	{
		public Action<IState> OnStaleHandler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public int Priority { get; set; } = 1;

		public virtual string Name { get => GetType().Name; set { } }

		public int ID { get => this.GetThisComponentIndex(); set { } }
	}
}
