using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TODO

namespace Cirrus.Unity.Animations
{
	public interface IAnimatorWrapper
	{
		Animator Animator { get; set; }

		CustomMonoBehaviourBase Component { get; set; }

		Action<int> OnAnimationFinishedHandler { get; set; }

		void Play(int animation, float normalizedTime, bool reset);

		void Play<T>(T animation, float normalizedTime, bool reset) where T : Enum;

		void Play<T>(T animation, bool reset) where T : Enum;


		void Push(int animation, float normalizedTime, bool reset);

		void Push<T>(T animation, float normalizedTime, bool reset) where T : Enum;

		void Push<T>(T animation, bool reset) where T : Enum;


		void Pop(int animation, float normalizedTime, bool reset);

		void Pop<T>(T animation, float normalizedTime, bool reset) where T : Enum;

		void Pop<T>(T animation, bool reset) where T : Enum;
	}

	//public enum AnimationFlags
	//{ 
	//	Reset = 1 << 0,
	//	Interrupt = 1 << 1
	//}

	public class AnimatorWrapperBase : ScriptableObjectBase
	{
		protected Animator _animator;
		public virtual Animator Animator { get => _animator; set => _animator = value; }

		private CustomMonoBehaviourBase _component;
		public virtual CustomMonoBehaviourBase Component
		{
			get => _component == null ?
				_component = Animator.gameObject.GetComponent<CustomMonoBehaviourBase>() :
				_component;
			set
			{
				_component = value;
			}
		}

		public Action<int> OnAnimationFinishedHandler { get; set; }

		private int _animation = -1;

		protected Dictionary<int, float> _stateSpeedValues = new Dictionary<int, float>();
		protected Dictionary<int, int> _stateLayerValues = new Dictionary<int, int>();

		public Stack<int> Stack { get; set; } = new Stack<int>();

		//////////////////////
		//////////////////////

		private bool _Play(int anim, float normalizedTime, bool reset = true)
		{
			if(!reset)
			{
				int layer = GetStateLayer(anim);
				var stateInfo = Animator.GetCurrentAnimatorStateInfo(layer);
				if(anim == stateInfo.shortNameHash)
				{
					if(stateInfo.loop) return false;
					if(stateInfo.normalizedTime < stateInfo.length) return false;
				}
			}

			if(_isAnimationFinishedCoroutineResult != null)
			{
				Component.StopCoroutine(_isAnimationFinishedCoroutineResult);
				_isAnimationFinishedCoroutineResult = null;
			}
			
			
			if(normalizedTime < 0) Animator.Play(anim);
			
			else Animator.Play(anim, -1, normalizedTime);

			_isAnimationFinishedCoroutineResult = Component.StartCoroutine(_IsAnimationFinishedCoroutine(anim));

			return true;
		}

		private Coroutine _isAnimationFinishedCoroutineResult;

		private WaitForEndOfFrame _waitEndOfFrame = new WaitForEndOfFrame();

		private IEnumerator _IsAnimationFinishedCoroutine(int anim)
		{
			int layer = GetStateLayer(anim);
			yield return _waitEndOfFrame;
			while(
				Animator.GetCurrentAnimatorStateInfo(layer).shortNameHash == anim &&
				Animator.GetCurrentAnimatorStateInfo(layer).normalizedTime < 1.0f
				)
			{
				yield return _waitEndOfFrame;
			}

			OnAnimationFinishedHandler?.Invoke(anim);
			yield return null;
		}

		public void Play(int animation, float normalizedTime, bool reset = true)
		{
			if(_Play(animation, normalizedTime, reset))
			{
				_animation = animation;
			}
		}

		public void Play<T>(T animation, float normalizedTime, bool reset = true) where T : Enum
		{
			Play((int)(object)animation, normalizedTime, reset);
		}

		public void Play(int animation, bool reset = true)
		{
			Play(animation, -1, reset);
		}

		public void Play<T>(T animation, bool reset = true) where T : Enum
		{
			Play((int)(object)animation, reset);
		}

		//////////////////////
		//////////////////////

		public void Push(int animation, float normalizedTime, bool reset = true)
		{
			if(_Play(animation, normalizedTime, reset))
			{
				if(Stack.Count == 0 && _animation != -1) Stack.Push(_animation);
				Stack.Push(animation);
				_animation = animation;
			}
		}

		public void Push<T>(T animation, float normalizedTime, bool reset = true) where T : Enum
		{
			Push((int)(object)animation, normalizedTime, reset);
		}

		public void Push(int animation, bool reset = true)
		{
			Push(animation, -1, reset);
		}

		public void Push<T>(T animation, bool reset = true) where T : Enum
		{
			Push((int)(object)animation, reset);
		}


		//////////////////////
		//////////////////////

		public void Pop(int animation, float normalizedTime, bool reset = true)
		{
			if(
				Stack.Count != 0 &&
				Stack.Peek() == animation
				)
			{
				Stack.Pop();
				Play(Stack.Peek(), normalizedTime, reset);
			}
		}

		public void Pop<T>(T animation, float normalizedTime, bool reset = true) where T : Enum
		{
			Pop((int)(object)animation, normalizedTime, reset);
		}

		public void Pop(int animation, bool reset = true)
		{
			Pop(animation, -1, reset);
		}

		public void Pop<T>(T animation, bool reset = true) where T : Enum
		{
			Pop((int)(object)animation, reset);
		}

		//////////////////////
		//////////////////////


		public float GetStateSpeed<T>(T animation) where T : Enum
		{
			return GetStateSpeed((int)(object)animation);
		}

		public float GetStateSpeed(int state)
		{
			if(_stateSpeedValues.TryGetValue(state, out float res)) return res;
			return -1f;
		}

		public int GetStateLayer<T>(T animation) where T : Enum
		{
			return GetStateLayer((int)(object)animation);
		}


		public int GetStateLayer(int state)
		{
			if(_stateLayerValues.TryGetValue(state, out int res)) return res;
			return -1;
		}
		public float GetClipLength<T>(T animation) where T : Enum
		{
			return GetClipLength((int)(object)animation);
		}

		public float GetClipLength(int state)
		{
			return -1f;
		}



	}
}
