using System;

namespace DnD5e_CBMobile_Core
{
	public class CharacterSheet
	{
		//Main Character Info
		public string CharacterName { get; set; }
		public string PlayerName { get; set; }
		public int ExperiencePoints { get; set; }

		public Attributes attributes;
		public int ProficiencyBonus { get; set; }

		public int Speed { get; set; }
	}
}

