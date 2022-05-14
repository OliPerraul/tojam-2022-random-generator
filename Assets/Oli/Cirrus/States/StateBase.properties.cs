using System;

namespace Cirrus.States
{
	public partial class StateBase<TContext>
	{
		public virtual int Priority { get; set; } = int.MaxValue;

		public virtual int ID { get; set; } = -1;

		public virtual string Name { get => GetType().Name; set { } }

		private TContext _context;
		public virtual TContext Context
		{
			get => _context;
			set
			{
				_context = value;
			}
		}

		public Action<IState> OnStaleHandler { get; set; }
	}
}
