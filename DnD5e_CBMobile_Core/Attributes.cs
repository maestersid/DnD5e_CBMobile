using System;

namespace DnD5e_CBMobile_Core
{
	public class Attributes
	{
		public int Strength { get; set; }

		public static Attributes operator +(Attributes op1, Attributes op2){
			return new Attributes {
				Strength = op1.Strength + op2.Strength
			};
		}
	}
}

