using Cirrus.Unity.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Broccoli 
{
    public class WaitNode : TaskNodeBase
    {
        private Range_ _seconds = -1;

		public override object Data { get => null; set { } }

		public WaitNode(Range_ seconds)
        {
            _seconds = seconds;
        }

        public WaitNode(string name) : base(name)
        {
        }

        public WaitNode(string name, object obj) : base(name, obj)
        {
        }

        public WaitNode(object obj) : base(obj)
        {
        }


        protected override void _Init()
        {
        }

        protected override void _Start()
        {
            Clock.AddTimer(_seconds, 0, _OnTimer);
        }

        protected override void _Stop()
        {
            Clock.RemoveTimer(_OnTimer);
            _OnStopped(false);
        }

        private void _OnTimer()
        {
            Clock.RemoveTimer(_OnTimer);
            _OnStopped(true);
        }
    }
}
