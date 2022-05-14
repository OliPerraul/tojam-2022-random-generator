using Cirrus.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Cirrus
{
	public static class StringUtils
	{
		public static readonly string UnknownName = "?";

		public static readonly string NullName = "null";

		public static readonly string InvalidName = "Invalid";

		public static float ExtractFloat(this string inp, out string rest)
		{
			rest = inp;
			for(int i = 0; i < inp.Length; i++) //loop the string
			{
				string candidate = inp.Substring(i, inp.Length);
				if(float.TryParse(candidate, out float res))
				{
					rest = inp.Substring(0, i);
					return Convert.ToSingle(candidate);
				}
			}

			return 0;
		}


		public static string PrettifyName(this string name)
		{
			return Regex.Replace(name, "(\\B[A-Z])", " $1");
		}

		public static string FromPascalToCamelCase(this string str)
		{
			if(!string.IsNullOrEmpty(str) && str.Length > 1)
			{
				return char.ToLowerInvariant(str[0]) + str.Substring(1);
			}
			return str;
		}

		public static string StripPrefix(this string name)
		{
			if (name.Contains("_"))
			{
				//return
				string[] splits =
					(name.StartsWith("_") ? name.Substring(1) : name)
					.Split('_');
				splits = splits.SubArray(1);
				return string.Join("_", splits);
			}

			return name;
		}


		public static string FormatResourceName(this string name, string delim=" ")
		{
			//return
			string[] splits =
				(name.StartsWith("_") ? name.Substring(1) : name)
				.Split('_');
			splits = splits.SubArray(1);
			for (int i = 0; i < splits.Length; i++)
			{
				splits[i] = splits[i].FromCamelToPascalCase().PrettifyName();
			}

			// Prevent inclusion of smaller string in larger
			// e.g. Avatar Debug Avatar..
			System.Collections.Generic.List<string> ss = new System.Collections.Generic.List<string>();
			for (int i = 0; i < splits.Length; i++)
			{
				bool skip = false;
				var s1 = splits[i];
				for (int j = 0; j < splits.Length; j++)
				{
					if (splits[i] == splits[j]) continue;
					var s2 = splits[j];
					if (s2.Length > s1.Length)
					{
						var s2Splits = s2.Split(" ");
						for (int k = 0; k < s2Splits.Length; k++)
						{
							if (s2Splits[k].Contains(s1))
							{
								skip = true;
								break;
							}
						}
						if (skip) break;
					}
				}

				if (skip) continue;
				ss.Add(s1);
			}

			return string.Join(delim, ss);
		}	

		public static string FormatPascalCase(this string name)
		{
			string[] splits = name.Split(' ');
			return string.Join("", splits);
		}

		public static string FromCamelToPascalCase(this string str)
		{
			if(!string.IsNullOrEmpty(str) && str.Length > 1)
			{
				return char.ToUpperInvariant(str[0]) + str.Substring(1);
			}
			return str;
		}

		public static string StripWhitespace(this string input)
		{
			return new string(input.ToCharArray()
				.Where(c => !char.IsWhiteSpace(c))
				.ToArray());
		}

		public static string UppercaseFirst(this string s)
		{
			if(s != string.Empty)
			{
				for(int i = 0; i < s.Length; i++)
				{
					if(!char.IsLetter(s[i])) continue;
					if(char.IsLower(s[0]))
					{
						s = char.ToUpper(s[i]) + s.Substring(i+1);
					}
					return s;
				}
			}

			return s;
		}

		public static string LowercaseFirst(this string s)
		{
			if(s != string.Empty)
			{
				for(int i = 0; i < s.Length; i++)
				{
					if(!char.IsLetter(s[i])) continue;
					if(char.IsUpper(s[i]))
					{
						s = char.ToLower(s[i]) + s.Substring(i+1);
					}
					return s;
				}
			}

			return s;
		}

		public static string Before(this string s, string toBeSearched = "@")
		{

			return s.Substring(0, s.IndexOf(toBeSearched));
		}

		public static string After(this string reference, string toBeSearched = "@")
		{
			return reference.Substring(
				toBeSearched.IndexOf(toBeSearched) + toBeSearched.Length);
		}


		public static char First(this string s)
		{
			return string.IsNullOrEmpty(s) ? default(char) : s[0];
		}

		public static char Last(this string s)
		{
			return string.IsNullOrEmpty(s) ? default(char) : s[s.Length - 1];
		}

		public static char Pop(this string s, int index, out string remaining)
		{
			char c = s[0];
			remaining = s.Remove(index, 1);

			return c;
		}

		public static char Pop(this string s, out string remaining)
		{
			return s.Pop(0, out remaining);
		}

		public static char PopRandom(this string s, out string remaining)
		{
			return s.Pop(Random.Range(0, s.Length), out remaining);
		}

		public static string PopRange(this string s, int startIndex, char stopCharacter, out string remaining)
		{
			string popped = "";
			int maximumIterations = s.Length;

			for(int i = 0; i < maximumIterations - startIndex; i++)
			{
				char c = s.Pop(startIndex, out s);

				if(c == stopCharacter)
					break;

				popped += c;
			}

			remaining = s;

			return popped;
		}

		public static string PopRange(this string s, char stopCharacter, out string remaining)
		{
			return s.PopRange(0, stopCharacter, out remaining);
		}

		public static string PopRange(this string s, int startIndex, int length, out string remaining)
		{
			string popped = "";

			for(int i = 0; i < length; i++)
				popped += s.Pop(startIndex, out s);

			remaining = s;

			return popped;
		}

		public static string PopRange(this string s, int length, out string remaining)
		{
			return s.PopRange(0, length, out remaining);
		}

		public static string GetRange(this string s, int startIndex, char stopCharacter)
		{
			string substring = "";

			for(int i = startIndex; i < s.Length; i++)
			{
				char c = s[i];

				if(c == stopCharacter)
					break;

				substring += c;
			}

			return substring;
		}

		public static string GetRange(this string s, char stopCharacter)
		{
			return s.GetRange(0, stopCharacter);
		}

		public static string GetRange(this string s, int startIndex, int length)
		{
			string substring = "";

			for(int i = startIndex; i < startIndex + length; i++)
				substring += s[i];

			return substring;
		}

		public static string GetRange(this string s, int startIndex)
		{
			return s.GetRange(startIndex, s.Length - startIndex);
		}

		public static string Reverse(this string s)
		{
			string reversed = "";

			for(int i = s.Length; i-- > 0;)
				reversed += s[i];

			return reversed;
		}

		public static string Capitalized(this string s)
		{
			string capitalized = "";

			if(!string.IsNullOrEmpty(s))
			{
				if(s.Length == 1)
					capitalized = char.ToUpper(s[0]).ToString();
				else
					capitalized = char.ToUpper(s[0]) + s.Substring(1);
			}

			return capitalized;
		}

		public static string[] SplitWords(this string s, int minWordLength)
		{
			System.Collections.Generic.List<string> words = new System.Collections.Generic.List<string>();
			int lastCapitalIndex = 0;
			int counter = 0;

			for(int i = 0; i < s.Length; i++)
			{
				if(counter >= minWordLength && i <= s.Length - minWordLength && (char.IsUpper(s[i]) || char.IsNumber(s[i])))
				{
					words.Add(s.Substring(lastCapitalIndex, counter));
					lastCapitalIndex = i;
					counter = 0;
				}

				counter += 1;
			}

			words.Add(s.Substring(lastCapitalIndex));

			return words.ToArray();
		}

		public static string[] SplitWords(this string s)
		{
			return SplitWords(s, 1);
		}

		public static T Capitalized<T>(this T stringArray) where T : IList<string>
		{
			for(int i = 0; i < stringArray.Count; i++)
				stringArray[i] = stringArray[i].Capitalized();

			return stringArray;
		}

		public static string Concat(this IList<string> stringArray, string separator, int startIndex, int count)
		{
			string concat = "";

			for(int i = startIndex; i < UnityEngine.Mathf.Min(startIndex + count, stringArray.Count); i++)
			{
				concat += stringArray[i];

				if(i < stringArray.Count - 1)
					concat += separator;
			}
			return concat;
		}

		public static string Concat(this IList<string> stringArray, string separator, int startIndex)
		{
			return stringArray.Concat(separator, startIndex, stringArray.Count - startIndex);
		}

		public static string Concat(this IList<string> stringArray, string separator)
		{
			return stringArray.Concat(separator, 0, stringArray.Count);
		}

		public static string Concat(this IList<string> stringArray, char separator)
		{
			return stringArray.Concat(separator.ToString(), 0, stringArray.Count);
		}

		public static string Concat(this IList<string> stringArray)
		{
			return stringArray.Concat(string.Empty);
		}

		public static float GetWidth(this string s, Font font)
		{
			float widthSum = 0;

			for(int i = 0; i < s.Length; i++)
			{
				char letter = s[i];
				CharacterInfo charInfo;
				font.GetCharacterInfo(letter, out charInfo);
				widthSum += charInfo.advance;
			}

			return widthSum;
		}

		public static Rect GetRect(this string s, Font font, int size = 10, FontStyle fontStyle = FontStyle.Normal)
		{
			float width = 0;
			float height = 0;
			float lineWidth = 0;
			float lineHeight = 0;

			foreach(char letter in s)
			{
				CharacterInfo charInfo;
				font.GetCharacterInfo(letter, out charInfo, size, fontStyle);

				if(letter == '\n')
				{
					if(lineHeight == 0) lineHeight = size;
					width = UnityEngine.Mathf.Max(width, lineWidth);
					height += lineHeight;
					lineWidth = 0;
					lineHeight = 0;
				}
				else
				{
					lineWidth += charInfo.advance;
					lineHeight = UnityEngine.Mathf.Max(lineHeight, charInfo.size);
				}
			}
			width = UnityEngine.Mathf.Max(width, lineWidth);
			height += lineHeight;

			return new Rect(0, 0, width, height);
		}

		public static GUIContent ToGUIContent(this string s, char labelTooltipSeparator)
		{
			string[] split = s.Split(labelTooltipSeparator);

			return new GUIContent(split[0], split[1]);
		}

		public static GUIContent ToGUIContent(this string s, string tooltip)
		{
			return new GUIContent(s, tooltip);
		}

		public static GUIContent ToGUIContent(this string s)
		{
			return new GUIContent(s);
		}

		public static GUIContent[] ToGUIContents(this IList<string> labels, char labelTooltipSeparator = '\0')
		{
			GUIContent[] guiContents = new GUIContent[labels.Count];

			for(int i = 0; i < labels.Count; i++)
			{
				if(labelTooltipSeparator != '\0')
				{
					string[] split = labels[i].Split(labelTooltipSeparator);
					if(split.Length == 1) guiContents[i] = new GUIContent(split[0]);
					else if(split.Length == 2) guiContents[i] = new GUIContent(split[0], split[1]);
					else guiContents[i] = new GUIContent(labels[i]);
				}
				else
					guiContents[i] = new GUIContent(labels[i]);
			}

			return guiContents;
		}

		public static GUIContent[] ToGUIContents(this IList<string> labels, IList<string> tooltips)
		{
			GUIContent[] guiContents = new GUIContent[labels.Count];

			for(int i = 0; i < labels.Count; i++)
				guiContents[i] = new GUIContent(labels[i], tooltips[i]);

			return guiContents;
		}

		public static bool IsNullOrEmpty(this string s)
		{
			return s == null || s.Equals("");
		}

		//public static bool IsNullEmptyOrUnknown(this string s)
		//{
		//	return s == null || s.Equals("") || s.Equals("?");
		//}
	}
}
