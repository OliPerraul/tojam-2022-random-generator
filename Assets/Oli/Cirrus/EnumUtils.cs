using System;
using System.Linq.Expressions;

namespace Cirrus
{
	public class EnumUtils
	{
		public static int Size(System.Type t)
		{
			return System.Enum.GetNames(t).Length;
		}
	}

	public enum UnknownEnum
	{ 
	}

    //void Main()
    //{
    //    Console.WriteLine("Cast (reference): {0}", (TestEnum)5);
    //    Console.WriteLine("EnumConverter: {0}", EnumConverter<TestEnum>.Convert(5));
    //    Console.WriteLine("Enum.ToObject: {0}", Enum.ToObject(typeof(TestEnum), 5));

    //    int iterations = 1000 * 1000 * 100;
    //    Measure(iterations, "Cast (reference)", () => { var t = (TestEnum)5; });
    //    Measure(iterations, "EnumConverter", () => EnumConverter<TestEnum>.Convert(5));
    //    Measure(iterations, "Enum.ToObject", () => Enum.ToObject(typeof(TestEnum), 5));
    //}   
}