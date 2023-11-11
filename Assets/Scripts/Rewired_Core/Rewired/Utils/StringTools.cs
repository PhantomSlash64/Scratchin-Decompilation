using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Rewired.Utils
{
	public static class StringTools
	{
		private static string rPLEEibPxWmxMzabiHVJeFJcrxbL;

		public static string ToString(int[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(float[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(string[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(bool[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(byte[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(byte[] inArray, string stringOptions, int maxItemsPerLine = 0)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i].ToString(stringOptions);
				if (maxItemsPerLine > 0)
				{
					if ((i + 1) % maxItemsPerLine == 0)
					{
						text += "\n";
					}
					else if (i < inArray.Length - 1)
					{
						text += ", ";
					}
				}
				else if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(Vector3[] inArray)
		{
			string text = "";
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i];
				if (i < inArray.Length - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(List<object> list)
		{
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text += list[i];
				if (i < list.Count - 1)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString(Vector2 v)
		{
			return v.x + ", " + v.y;
		}

		public static string ToString(Vector3 v)
		{
			return v.x + ", " + v.y + ", " + v.z;
		}

		public static string ToString<T>(T[] inArray)
		{
			string text = "";
			int num = inArray.Length - 1;
			for (int i = 0; i < inArray.Length; i++)
			{
				text += inArray[i].ToString();
				if (i < num)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string ToString<T>(List<T> inList)
		{
			string text = "";
			int num = inList.Count - 1;
			for (int i = 0; i < inList.Count; i++)
			{
				text += inList[i].ToString();
				if (i < num)
				{
					text += ", ";
				}
			}
			return text;
		}

		public static string[] Split(string str, string delimiter)
		{
			return str?.Split(delimiter[0]);
		}

		public static string[] SplitAndTrim(string str, string delimiter)
		{
			if (str == null)
			{
				return null;
			}
			string[] array = Split(str, delimiter);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				array[i] = text.Trim();
			}
			return array;
		}

		public static string DecodeNewlines(string s)
		{
			return s.Replace("\\r\\n", "\n");
		}

		public static string EncodeNewlines(string s)
		{
			return s.Replace("\n", "\\r\\n");
		}

		public static string ArrayToText(string[] sA)
		{
			string text = "";
			for (int i = 0; i < sA.Length; i++)
			{
				string text2 = sA[i];
				if (i != 0)
				{
					text += "\n";
				}
				text += text2;
			}
			return text;
		}

		public static string[] TextToArray(string s)
		{
			return s.Split("\n"[0]);
		}

		public static string StringToString(string s)
		{
			if (s == null)
			{
				return "";
			}
			return s;
		}

		public static int StringToInt(string s)
		{
			int.TryParse(s, out var result);
			return result;
		}

		public static float StringToFloat(string s)
		{
			float.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var result);
			return result;
		}

		public static bool StringToBoolean(string s)
		{
			bool.TryParse(s, out var result);
			return result;
		}

		public static KeyCode StringToKeyCode(string s)
		{
			return (KeyCode)Enum.Parse(typeof(KeyCode), s);
		}

		public static Enum StringToEnum(string str, Type type)
		{
			return (Enum)Enum.Parse(type, str);
		}

		public static string ToStringWithCount(string s)
		{
			if (s == "" || s == null)
			{
				return "0|";
			}
			s = s.Replace("|"[0], ""[0]);
			if (s == "" || s == null)
			{
				return "0|";
			}
			s = s.Length + "|" + s;
			return s;
		}

		public static char[] StringToCharArray(string s)
		{
			return s?.ToCharArray();
		}

		public static string CharArrayToString(char[] c)
		{
			if (c == null)
			{
				return null;
			}
			return new string(c);
		}

		public static string CSVEncode(string s)
		{
			if (s == null || s == "")
			{
				return ",";
			}
			s = s.Replace("\\", "\\\\");
			s = s.Replace(",", "\\,");
			return s + ",";
		}

		public static string CSVDecode(string s)
		{
			if (s == null || s == "")
			{
				return "";
			}
			char c = ","[0];
			char c2 = "\\"[0];
			bool flag = false;
			bool flag2 = false;
			string text = "";
			for (int i = 0; i < s.Length; i++)
			{
				flag2 = false;
				if (s[i] == c2)
				{
					if (flag)
					{
						flag2 = true;
					}
					flag = !flag;
				}
				else if (s[i] == c && flag)
				{
					flag2 = true;
					flag = false;
				}
				else
				{
					flag = false;
				}
				if (flag2)
				{
					text = text.Substring(0, text.Length - 1);
				}
				text += s[i];
			}
			return text;
		}

		public static string[] CSVToArray(string s)
		{
			if (s == null || s == "")
			{
				return null;
			}
			char c = ","[0];
			char c2 = "\\"[0];
			List<object> list = new List<object>();
			string text = "";
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == c2)
				{
					flag = !flag;
				}
				else
				{
					if (s[i] == c && !flag)
					{
						flag2 = true;
					}
					flag = false;
				}
				if (!flag2)
				{
					text += s[i];
					continue;
				}
				text = CSVDecode(text);
				list.Add(text);
				text = "";
				flag2 = false;
			}
			string[] array = new string[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				array[j] = (string)list[j];
			}
			return array;
		}

		public static bool TryParseEnum<TEnum>(string value, out TEnum enumeration)
		{
			enumeration = default(TEnum);
			if (string.IsNullOrEmpty(value))
			{
				return false;
			}
			Type typeFromHandle = typeof(TEnum);
			try
			{
				enumeration = (TEnum)Enum.Parse(typeFromHandle, value, ignoreCase: true);
			}
			catch (ArgumentException)
			{
				return false;
			}
			return true;
		}

		public static string TimeToString(int seconds)
		{
			return TimeToString((float)seconds);
		}

		public static string TimeToString(float seconds)
		{
			if (seconds == 0f)
			{
				return seconds + " seconds";
			}
			float num = MathTools.Abs(seconds);
			int num2 = MathTools.FloorToInt(num / 3600f);
			num -= (float)(num2 * 3600);
			int num3 = MathTools.FloorToInt(num / 60f);
			num -= (float)(num3 * 60);
			float num4 = num;
			string text = "";
			if (num2 > 0)
			{
				text = text + num2 + " h";
			}
			if (num3 > 0)
			{
				if (text != "")
				{
					text += ", ";
				}
				text = text + num3 + " m";
			}
			if (num4 > 0f)
			{
				if (text != "")
				{
					text += ", ";
				}
				text = text + num4 + " s";
			}
			return text;
		}

		static StringTools()
		{
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			rPLEEibPxWmxMzabiHVJeFJcrxbL = Regex.Escape(new string(invalidFileNameChars));
		}

		public static string CleanUpFileName(string name)
		{
			name = name.Trim();
			string pattern = "[ ~`,:;'\\.\\$\\^\\{\\}\\[\\]\\(\\|\\)\\*\\+\\?\\\\" + rPLEEibPxWmxMzabiHVJeFJcrxbL + "]";
			name = Regex.Replace(name, pattern, "_");
			return name;
		}

		public static string StripTrailingNumbers(string name)
		{
			int number;
			return StripTrailingNumbers(name, out number);
		}

		public static string StripTrailingNumbers(string name, out int number)
		{
			Match match = Regex.Match(name, "[0-9]+$");
			if (!match.Success)
			{
				number = -1;
				return name;
			}
			if (!int.TryParse(match.Value, out number))
			{
				throw new Exception("Could not parse string to Int32! " + match.Value);
			}
			int index = match.Index;
			if (index == 0)
			{
				return "";
			}
			return name.Substring(0, index);
		}

		public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars)
		{
			return VerifyName(name, indexInNameList, names, cleanUpIllegalFileChars, allowBlank: false);
		}

		public static string VerifyName(string name, int indexInNameList, string[] names, bool cleanUpIllegalFileChars, bool allowBlank)
		{
			if (cleanUpIllegalFileChars)
			{
				name = CleanUpFileName(name);
			}
			else if (name != null)
			{
				name = name.Trim();
			}
			if (!allowBlank && string.IsNullOrEmpty(name))
			{
				name = "0";
			}
			if (allowBlank && string.IsNullOrEmpty(name))
			{
				return name;
			}
			int num = ((names != null) ? names.Length : 0);
			if (num == 0)
			{
				return name;
			}
			for (int i = 0; i < num; i++)
			{
				if (i != indexInNameList && names[i] != null && name.Equals(names[i], StringComparison.OrdinalIgnoreCase))
				{
					return IterateName(name, indexInNameList, names);
				}
			}
			return name;
		}

		public static string IterateName(string name, int indexInNameList = -1, string[] names = null)
		{
			int number;
			string text = StripTrailingNumbers(name, out number);
			if (names != null)
			{
				int num = -1;
				int num2 = names.Length;
				for (int i = 0; i < num2; i++)
				{
					if (i != indexInNameList && names[i] != null)
					{
						string name2 = names[i];
						name2 = StripTrailingNumbers(name2, out var number2);
						if (text.Equals(name2, StringComparison.OrdinalIgnoreCase) && number2 > num)
						{
							num = number2;
						}
					}
				}
				num++;
				return text + num;
			}
			return text + (number + 1);
		}

		public static string ToString(Rect rect)
		{
			return $"{rect.x}, {rect.y}, {rect.width}, {rect.height}";
		}

		public static Guid ToGuid(string guid)
		{
			try
			{
				return new Guid(guid);
			}
			catch
			{
				return Guid.Empty;
			}
		}

		public static byte[] GetBytes(string str)
		{
			byte[] array = new byte[str.Length * 2];
			Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		public static string GetString(byte[] bytes)
		{
			char[] array = new char[bytes.Length / 2];
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return new string(array);
		}

		public static string ByteShiftEncode(string source, short shift)
		{
			if (source == null || source == string.Empty)
			{
				return string.Empty;
			}
			int num = Convert.ToInt32('\uffff');
			int num2 = Convert.ToInt32('\0');
			char[] array = source.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				int num3 = Convert.ToInt32(array[i]) + shift;
				if (num3 > num)
				{
					num3 -= num;
				}
				else if (num3 < num2)
				{
					num3 += num;
				}
				array[i] = Convert.ToChar(num3);
			}
			return new string(array);
		}

		public static string GetNullTerminatedUnicodeString(byte[] bytes)
		{
			if (bytes == null || bytes.Length < 3)
			{
				return string.Empty;
			}
			int num = -1;
			for (int i = 0; i < bytes.Length; i += 2)
			{
				if (bytes[i] == 0)
				{
					num = i - 1;
					break;
				}
			}
			if (num < 0)
			{
				return string.Empty;
			}
			int count = num + 1;
			return Encoding.Unicode.GetString(bytes, 0, count);
		}

		public static string SanitizeDeviceString(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			try
			{
				string pattern = "[\\x1A]";
				return Regex.Replace(text, pattern, "");
			}
			catch
			{
				return string.Empty;
			}
		}

		public static string ReplaceChar(string @string, int index, char replacement)
		{
			if (string.IsNullOrEmpty(@string))
			{
				return @string;
			}
			if (index >= @string.Length)
			{
				return @string;
			}
			if (index < 0)
			{
				return @string;
			}
			char[] array = @string.ToCharArray();
			array[index] = replacement;
			return new string(array);
		}

		public static string AddSpacesToSentence(string text, bool preserveAcronyms)
		{
			if (string.IsNullOrEmpty(text))
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder(text.Length * 2);
			stringBuilder.Append(text[0]);
			for (int i = 1; i < text.Length; i++)
			{
				if (char.IsUpper(text[i]) && ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) || (preserveAcronyms && char.IsUpper(text[i - 1]) && i < text.Length - 1 && !char.IsUpper(text[i + 1]))))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(text[i]);
			}
			return stringBuilder.ToString();
		}

		public static string WriteVar(string name, object value)
		{
			return WriteVar(name, value, '=');
		}

		public static string WriteVar(string name, object value, char delimiter)
		{
			return name + " " + delimiter + " " + ((value != null) ? value.ToString() : "NULL") + "\n";
		}

		public static void WriteVar(StringBuilder sb, string name, object value)
		{
			WriteVar(sb, name, value, '=');
		}

		public static void WriteVar(StringBuilder sb, string name, object value, char delimiter)
		{
			sb.Append(name);
			sb.Append(" ");
			sb.Append(delimiter);
			sb.Append(" ");
			sb.Append((value != null) ? value.ToString() : ((value is string) ? string.Empty : "NULL"));
			sb.Append("\n");
		}

		public static string Trim(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				return str;
			}
			return str.Trim();
		}

		public static string VariableNameToDisplayName(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				return fieldName;
			}
			fieldName = Regex.Replace(fieldName, "[^a-zA-Z0-9_]", "");
			fieldName = Regex.Replace(fieldName, "[_]{2,}", "_");
			if (fieldName.StartsWith("m_") && fieldName.Length > 2)
			{
				fieldName = fieldName.Substring(2);
			}
			fieldName = Regex.Replace(fieldName, "[_]", " ");
			fieldName = fieldName.Trim();
			MatchCollection matchCollection = Regex.Matches(fieldName, "\\b([a-z])");
			char[] array = fieldName.ToCharArray();
			for (int i = 0; i < matchCollection.Count; i++)
			{
				int index = matchCollection[i].Index;
				array[index] = array[index].ToString().ToUpper()[0];
			}
			fieldName = AddSpacesToSentence(new string(array), preserveAcronyms: false);
			return Regex.Replace(fieldName, "([a-zA-Z_]+)([0-9]+)", "$1 $2");
		}

		public static int CountChars(string text, char character)
		{
			if (string.IsNullOrEmpty(text))
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == character)
				{
					num++;
				}
			}
			return num;
		}
	}
}
