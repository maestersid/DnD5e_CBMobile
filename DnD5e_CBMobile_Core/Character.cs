using System;

namespace DnD5e_CBMobile_Core
{
	public class Character 
	{
		private Attributes baseAttributes;
		public Race Race { get; set; }

		public Attributes FinalAttributes { get { return baseAttributes + Race.BonusAttributes;} }

		public void SetBaseAttributes (Attributes attributes)
		{
			baseAttributes = attributes;
		}
	}
	
}
