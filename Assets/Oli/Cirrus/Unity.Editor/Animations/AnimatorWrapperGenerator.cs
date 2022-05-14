#if UNITY_EDITOR

using Cirrus.Source;
using Cirrus.Unity.Editor;
using Cirrus.Unity.Objects;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Animations
{
	public class AnimatorWrapperGenerator : ScriptableObject
	{
		[MenuItem("Assets/Create/Cirrus.Unity/Animations/AnimatorWrapperGenerator", false, priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void CreateAsset() => EditorScriptableObjectUtils.CreateAsset<AnimatorWrapperGenerator>();

		public const string SafeSuffix = "_Safe";

		[SerializeField]
		public string DefinePrefix = "HEALER_";

		[SerializeField]
		private UnityEditor.Animations.AnimatorController _animator;

		[SerializeField]
		public string _name;

		[SerializeField]
		public string _namespace;


		[SerializeField]
		public string _assetMenu;

		private const int kSpacesPerIndentLevel = 4;

		public static string FormatField(string field)
		{
			return field.ToLower().Replace(" ", "");
		}

		public static string FormatProperty(string property)
		{
			string res = property.First().ToString().ToUpper() + property.Substring(1);
			return res.Replace(" ", "");
		}

		public static string GetTypeString1(AnimatorControllerParameterType type)
		{
			switch(type)
			{
				case AnimatorControllerParameterType.Bool:
					return "bool";
				case AnimatorControllerParameterType.Float:
					return "float";
				case AnimatorControllerParameterType.Int:
					return "int";
				case AnimatorControllerParameterType.Trigger:
					return "void";
				default:
					return "";
			}
		}

		public static string GetTypeString2(AnimatorControllerParameterType type)
		{
			switch(type)
			{
				case AnimatorControllerParameterType.Bool:
					return "Bool";
				case AnimatorControllerParameterType.Float:
					return "Float";
				case AnimatorControllerParameterType.Int:
					return "Integer";
				case AnimatorControllerParameterType.Trigger:
					return "Trigger";
				default:
					return "";

			}
		}


		public static string FormatClass(string cls)
		{
			return $"{cls}AnimatorWrapper";
		}

		public static string FormatInterface(string cls)
		{
			return "I" + FormatClass(cls);
		}


		public static string FormatAnimationEnum(string cls)
		{
			return $"{cls}AnimationID";
		}

		public static string FormatAnimation(string cls)
		{
			return cls;
		}

		public static string FormatClip(string state)
		{
			return state.Replace("_", ".");
		}

		//public string FormatLayer(string cls)
		//{
		//	return cls.Remove(;
		//}

		private const string _stateSpeedValuesString = "_stateSpeedValues";
		private const string _stateLayerValuesString = "_stateLayerValues";

		public string GenerateWrapperCode()
		{
			if(string.IsNullOrEmpty(_name))
			{
			}

			var writer = new Writer
			{
				buffer = new StringBuilder()
			};


			// Usings.
			writer.WriteLine("using System;");
			writer.WriteLine("using System.Collections;");
			writer.WriteLine("using System.Collections.Generic;");
			writer.WriteLine("using UnityEngine;");
			writer.WriteLine("using Cirrus.Unity.Animations;");
			writer.WriteLine("using Cirrus.Unity.Editor;");
			writer.WriteLine("using UnityEditor;");

			// Begin namespace.

			writer.WriteLine($"namespace {_namespace}");
			writer.BeginBlock();

			// Begin Animation Enum
			writer.WriteLine($"public enum {FormatAnimationEnum(_name)}");
			writer.BeginBlock();
			foreach(var layer in _animator.layers)
			{
				foreach(var state in layer.stateMachine.states)
				{
					writer.WriteLine($"{FormatAnimation(state.state.name)}={state.state.nameHash},");
				}
			}
			writer.EndBlock();


			// Begin interface.
			writer.WriteLine($"public interface {FormatInterface(_name)} : {nameof(IAnimatorWrapper)}");
			writer.BeginBlock();
			//writer.WriteLine($"Animator Animator {{get; set;}}");
			//writer.WriteLine($"void Play({FormatAnimationEnum(_name)} animation, float normalizedTime, bool reset=true);");
			//writer.WriteLine($"void Play({FormatAnimationEnum(_name)} animation, bool reset=true);");
			// Properties
			foreach(var param in _animator.parameters)
			{
				string endline = "";
				endline = param.type == AnimatorControllerParameterType.Trigger ?
					$"void {FormatProperty(param.name)}();" :
					$"{GetTypeString1(param.type)} {FormatProperty(param.name)} {{ set; }}";
				writer.WriteLine(endline);

				endline = param.type == AnimatorControllerParameterType.Trigger ?
					$"void {FormatProperty(param.name)}{SafeSuffix}();" :
					$"{GetTypeString1(param.type)} {FormatProperty(param.name)}{SafeSuffix}{{ set; }}";
				writer.WriteLine(endline);
			}

			for(int i = 0; i < _animator.layers.Length; i++)
			{
				writer.WriteLine($"float {FormatProperty(_animator.layers[i].name)}LayerWeight{{set;}}");
				writer.WriteLine($"float {FormatProperty(_animator.layers[i].name)}LayerWeight{SafeSuffix}{{set;}}");
			}

			writer.EndBlock();


			// Begin class.
			writer.WriteLine($"public class {FormatClass(_name)} : {nameof(AnimatorWrapperBase)}, {FormatInterface(_name)}");
			writer.BeginBlock();

			writer.Write($@"
			[MenuItem(""Assets/Create/{_assetMenu}"", false, priority = PackageUtils.MenuItemAssetFrameworkPriority)]
			public static void CreateAsset() => EditorScriptableObjectUtils.CreateAsset<{FormatClass(_name)}>();
			");
			//writer.WriteLine($"private Animator _animator;");
			//writer.WriteLine($"private Dictionary<{FormatAnimationEnum(_name)},float> {_stateSpeedValuesString} = new Dictionary<{FormatAnimationEnum(_name)},float>();");
			//writer.WriteLine($"private Dictionary<{FormatAnimationEnum(_name)},int> {_stateLayerValuesString} = new Dictionary<{FormatAnimationEnum(_name)},int>();");

			// Play method
			//writer.WriteLine($"public void Play({FormatAnimationEnum(_name)} animation, float normalizedTime, bool reset=true)");
			//writer.BeginBlock();
			//writer.WriteLine("if (_animator == null) return; ");

			//writer.WriteLine("if(!reset)");
			//writer.BeginBlock();
			//writer.WriteLine("int layer = GetStateLayer(animation);");
			//writer.WriteLine("var stateInfo = _animator.GetCurrentAnimatorStateInfo(layer);");
			//writer.WriteLine("if((int)animation == stateInfo.GetHashCode())");
			//writer.BeginBlock();
			//writer.WriteLine("if (stateInfo.loop) return;");
			//writer.WriteLine("if (stateInfo.normalizedTime <= stateInfo.length) return;");
			//writer.EndBlock();
			//writer.EndBlock();
			//writer.WriteLine("if(normalizedTime < 0) _animator.Play((int)animation);");
			//writer.WriteLine("else _animator.Play((int)animation, -1, normalizedTime);");
			//writer.EndBlock();

			//writer.WriteLine($"public void Play({FormatAnimationEnum(_name)} animation, bool reset=true)");
			//writer.BeginBlock();
			//writer.WriteLine("Play(animation, -1, reset);");
			//writer.EndBlock();

			// Properties
			foreach (var param in _animator.parameters)
			{
				string endline = "";
				endline = param.type == AnimatorControllerParameterType.Trigger ?
					$"(){{ if(_animator != null && _animator.isActiveAndEnabled && _animator.runtimeAnimatorController != null) _animator.Set{ GetTypeString2(param.type)}({Animator.StringToHash(param.name)}); }}" :
					$"{{ set {{ if(_animator != null && _animator.isActiveAndEnabled && _animator.runtimeAnimatorController != null)_animator.Set{ GetTypeString2(param.type)}({Animator.StringToHash(param.name)}, value); }} }}";
				writer.WriteLine($"public {GetTypeString1(param.type)} {FormatProperty(param.name)}{SafeSuffix}" + endline);

				endline = param.type == AnimatorControllerParameterType.Trigger ?
					$"(){{ _animator.Set{ GetTypeString2(param.type)}({Animator.StringToHash(param.name)}); }}" :
					$"{{ set {{ _animator.Set{ GetTypeString2(param.type)}({Animator.StringToHash(param.name)}, value); }} }}";
				writer.WriteLine($"public {GetTypeString1(param.type)} {FormatProperty(param.name)}" + endline);

			}

			for(int i = 0; i < _animator.layers.Length; i++)
			{
				writer.WriteLine($"public float {FormatProperty(_animator.layers[i].name)}LayerWeight{SafeSuffix}{{set {{ if(_animator != null && _animator.isActiveAndEnabled && _animator.runtimeAnimatorController != null) _animator.SetLayerWeight({i},value);}} }}");
				writer.WriteLine($"public float {FormatProperty(_animator.layers[i].name)}LayerWeight{{set {{ _animator.SetLayerWeight({i},value);}} }}");
			}

			// get; set; Animator
			writer.WriteLine("public override Animator Animator {get => _animator; set");
			writer.BeginBlock();
			writer.WriteLine("if(value==null)return;");
			writer.WriteLine("_animator = value;");
			foreach(var layer in _animator.layers)
			{
				foreach(var state in layer.stateMachine.states)
				{
					writer.WriteLine($"{_stateSpeedValuesString}.Add((int){FormatAnimationEnum(_name)}.{FormatAnimation(state.state.name)}, {state.state.speed});");
					writer.WriteLine($"{_stateLayerValuesString}.Add((int){FormatAnimationEnum(_name)}.{FormatAnimation(state.state.name)}, _animator.GetLayerIndex(\"{layer.name}\"));");
				}
			}
			writer.EndBlock();
			writer.WriteLine("}");

			// Constructor
			writer.WriteLine($"public {FormatClass(_name)}()");
			writer.BeginBlock();
			writer.EndBlock();
			writer.WriteLine($"public {FormatClass(_name)}(Animator animator)");
			writer.BeginBlock();
			writer.WriteLine("Animator = animator;");
			writer.EndBlock();

			//writer.WriteLine($"public float GetStateSpeed({FormatAnimationEnum(_name)} state)");
			//writer.BeginBlock();
			//writer.WriteLine($"if({_stateSpeedValuesString}.TryGetValue(state, out float res)) return res;");
			//writer.WriteLine("return -1f;");
			//writer.EndBlock();

			//writer.WriteLine($"public int GetStateLayer({FormatAnimationEnum(_name)} state)");
			//writer.BeginBlock();
			//writer.WriteLine($"if({_stateLayerValuesString}.TryGetValue(state, out int res)) return res;");
			//writer.WriteLine("return -1;");
			//writer.EndBlock();


			//writer.WriteLine($"public float GetClipLength({FormatAnimationEnum(_name)} state)");
			//writer.BeginBlock();
			//writer.WriteLine("return -1f;");
			//writer.EndBlock();


			// End class
			writer.EndBlock();

			// End namespace
			writer.EndBlock();


			return writer.buffer.ToString();
		}

		private struct Writer
		{
			public StringBuilder buffer;
			public int indentLevel;

			public void BeginBlock()
			{
				WriteIndent();
				buffer.Append("{\n");
				++indentLevel;
			}

			public void EndBlock()
			{
				--indentLevel;
				WriteIndent();
				buffer.Append("}\n");
			}

			public void WriteLine()
			{
				buffer.Append('\n');
			}

			public void WriteLine(string text)
			{
				WriteIndent();
				buffer.Append(text);
				buffer.Append('\n');
			}

			public void Write(string text)
			{
				buffer.Append(text);
			}

			public void WriteIndent()
			{
				for(var i = 0; i < indentLevel; ++i)
				{
					for(var n = 0; n < kSpacesPerIndentLevel; ++n)
						buffer.Append(' ');
				}
			}
		}

		public void GenerateAnimatorWrapperFile()
		{
			string filePath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(this));

			filePath += $"/{FormatClass(_name)}.cs";

			// Generate code.
			var code = GenerateWrapperCode();

			// Write.
			File.WriteAllText(filePath, code);
		}

	}



	[CustomEditor(typeof(AnimatorWrapperGenerator))]
	public class SomeScriptEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			AnimatorWrapperGenerator o = (AnimatorWrapperGenerator)target;
			if(GUILayout.Button("Generate"))
			{
				o.GenerateAnimatorWrapperFile();
				ProjectUtils.AddDefineSymbols
					($"{CodeGenUtils.DefinePrefix}{o.DefinePrefix}{AnimatorWrapperGenerator.FormatClass(o._name).FormatDefine()}");
			}
		}
	}
}


#endif