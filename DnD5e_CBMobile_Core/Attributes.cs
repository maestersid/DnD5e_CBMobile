using System;

namespace DnD5e_CBMobile_Core
{
	public class Attributes
	{
		public int Strength { get; set; }
		public int Dexerity { get; set; }
		public int Constitution { get; set; }
		public int Intelligence { get; set; }
		public int Wisdom { get; set; }
		public int Charisma { get; set; }

		public static Attributes operator +(Attributes op1, Attributes op2){
			return new Attributes {
				Strength = op1.Strength + op2.Strength
			};
		}

		public static int GetMod(int attr)
		{
			return (attr - 10) / 2;
		}
	}
}

