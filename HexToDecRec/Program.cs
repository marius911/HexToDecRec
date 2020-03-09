using System;

namespace HexToDecRec
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Recursive("12f"));
        }

		private static int Recursive(string hexNumber)
		{
			int deci = 0;
			String hexCode = "0123456789ABCDEF";
			hexNumber = hexNumber.ToUpper();
			int length = hexNumber.Length;
			if (length > 0)
			{
				char ch = hexNumber[0];
				int digit = hexCode.IndexOf(ch);
				String substring = hexNumber.Substring(1);
				deci = digit * (int)Math.Pow(16, length - 1) + Recursive(substring);
			}
			return deci;
		}
	}
}
