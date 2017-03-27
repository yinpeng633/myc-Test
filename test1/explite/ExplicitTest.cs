using System;
namespace test1
{
	public class ExplicitTest
	{
		static void Main (string [] args)
		{
            RomanNumber roman;
            roman = 10;

			Console.WriteLine((int)roman);

			Console.WriteLine(roman);

			short s = (short)roman;

			Console.WriteLine(s);
		}
	}



    public class RomanNumber
    {
        private int value;

		public RomanNumber(int value)
        {
            this.value = value;
        }

		//roman = 10; 可以d
		static public implicit operator RomanNumber(int value)
        {
            return new RomanNumber(value);
        }


		static public explicit operator int(RomanNumber roman)
        {
            return roman.value;
        }

        static public implicit operator string(RomanNumber roman)
        {
			return ("Conversion not yet implemented");
        }
    }
}
