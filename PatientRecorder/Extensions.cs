using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientRecorder
{
	static class Extensions
	{
		public static string ToListString(this List<string> collection)
		{
			if (collection == null || collection.Count == 0)
				return "";
			StringBuilder str = new StringBuilder(32);
			foreach (var item in collection)
			{
				str.Append(item).Append(", ");
			}
			if (str.Length >= 2)
				str.Remove(str.Length - 2, 2);
			return str.ToString();
		}
	}
}
