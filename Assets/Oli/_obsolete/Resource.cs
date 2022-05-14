using Cirrus.Objects;
using Cirrus.Unity.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tojam2022
{
	public abstract partial class ResourceInstanceBase<TResource> : Base
	{
		protected TResource _resource;
		public ResourceInstanceBase(TResource resource)
		{
			_resource = resource;
		}
	}


	public abstract partial class FactoryAssetBase<TInstance>
	: ScriptableObjectBase
	{
		protected abstract TInstance _CreateInstance();

		protected virtual void _PopulateInstance(TInstance inst)
		{
		}

		// TODO: C# 9 subst "new hiding" with return covariant 
		// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns
		// https://docs.unity3d.com/2022.2/Documentation/Manual/CSharpCompiler.html
		public TInstance CreateInstance()
		{
			var inst = _CreateInstance();
			_PopulateInstance(inst);
			return inst;
		}
	}

	public abstract partial class FactoryComponentBase<TInstance>
	: MonoBehaviourBase
	{
		protected abstract TInstance _CreateInstance();

		protected virtual void _PopulateInstance(TInstance inst)
		{
		}

		// TODO: C# 9 subst "new hiding" with return covariant 
		// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns
		// https://docs.unity3d.com/2022.2/Documentation/Manual/CSharpCompiler.html
		public TInstance CreateInstance()
		{
			var inst = _CreateInstance();
			_PopulateInstance(inst);
			return inst;
		}
	}


	public abstract partial class ParameterlessFactoryAssetBase<TInstance> : FactoryAssetBase<TInstance>
		where TInstance : new()
	{
		protected override TInstance _CreateInstance() => new TInstance();
	}

	public abstract partial class ParameterlessFactoryComponentBase<TInstance> : FactoryComponentBase<TInstance>
	where TInstance : new()
	{
		protected override TInstance _CreateInstance() => new TInstance();
	}

}
