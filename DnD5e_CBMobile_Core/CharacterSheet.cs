using System;

namespace DnD5e_CBMobile_Core
{
	public class CharacterSheet
	{
		//Main Character Info
		public string CharacterName { get; set; }
		public string PlayerName { get; set; }
		public int ExperiencePoints { get; set; }

		public int PlayerLevel { get; set; }
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

		public CharacterSheet(){

		}

		public CharacterSheet(bool isDummy)
		{
			if (isDummy) {

				//Create Test Character
				CharacterName = "Leeroy";
				PlayerName = "James";
				PlayerLevel = 1;
				ProficiencyBonus = 2;

				Race = new Race{ BonusAttributes = new Attributes { Strength = 2, Charisma = 1 }, Name = "Human" };

				var attributes = new Attributes {
					Strength = 15,
					Dexterity = 14,
					Constitution = 13,
					Intelligence = 12,
					Wisdom = 10,
					Charisma = 8
				};
				baseAttributes = attributes;
			}

		}

	}
}

