using System;
using System.Globalization;

namespace Utils {
	class time {
		public static string GetCurrentDateTime() {
			const string REGION = "en-AU";
			CultureInfo culture = new CultureInfo(REGION);
			DateTime current = DateTime.Now;
			return current.ToString(culture);
		}
	}
	class decor {
		public static void PrintHorizontalDivider(int length = 80) {
			for (int i = 0; i < length; i++) {
				Console.Write("#");
			}
			Console.WriteLine();
		}
	}
}