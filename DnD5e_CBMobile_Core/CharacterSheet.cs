using System;

namespace DnD5e_CBMobile_Core
{
	public class CharacterSheet
	{
		//Main Character Info
		public string CharacterName { get; set; }
		public string PlayerName { get; set; }
		public int ExperiencePoints { get; set; }

		public int ProficiencyBonus { get; set; }

		public int Speed { get; set; }

		private Attributes baseAttributes;

		public Race Race { get; set; }

		public PlayerClass Class { get; set; }

		public Attributes FinalAttributes { get { return baseAttributes + Race.BonusAttributes;} }

		public void SetBaseAttributes (Attributes attributes)
		{
			baseAttributes = attributes;
		}

	}
}

