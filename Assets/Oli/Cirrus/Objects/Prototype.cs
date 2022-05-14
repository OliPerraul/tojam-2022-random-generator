// Allow text management via json

namespace Cirrus.Objects
{
	// TODO: rename IPrototype to IMixin or something idk

	// TODO:
	// * OnCloned should be replaced with Decorator
	// * Decorator should only be called on finalize clone
	// * Decorator should not be handled by nested lambdas
	//public interface IRealizablePrototype : ICopiablePrototype
	//{
	//	// Last realize step data
	//	object[] RealizeStepCbs { get; set; }

	//	bool IsRealizable { get; set; }

	//	object ProxyCb { get; set; }

	//	object ProtoData { get; set; }

	//	void OnResourceRealized();
	//}

	//public abstract class PrototypeBase : ResourceBase, IPrototype
	//{
	//	public object[] Mixins { get; set; }

	//	public abstract object Clone();

	//	public virtual object Copy()
	//	{
	//		return MemberwiseClone();
	//	}

	//	public virtual void OnRealized()
	//	{
	//	}
	//}
}
