using System.Collections.Generic;


namespace DnD5e_CBMobile_Core
{
	public class CharacterSheet
	{
		//Main Character Info
		public string CharacterName { get; set; }

		private AlignmentInfo.Alignment _playerAlignment;

		public string Alignment { 
			get {
				return AlignmentInfo.GetAlignment (_playerAlignment);
			}
			set {
				_playerAlignment = AlignmentInfo.SetAlignment (value);
			}
		}

		public int ExperiencePoints { get; set; }

		public int CharacterLevel { get; set; }

		public int ProficiencyBonus { get; set; }

		public int Speed { get; set; }

		public RaceHelper Race { get; set; }

		public PlayerClass Class { get; set; }

		public SkillsList Skills{ get; set; }

		public CharacterBackground Background { get; set; }

		private Attributes baseAttributes;

		public Attributes FinalAttributes { get { return baseAttributes + Race.BonusAttributes; } }

		public CharacterSheet ()
		{
		}

		public void SetBaseAttributes (Attributes attributes)
		{
			baseAttributes = attributes;
		}

		/*
		 * Helper method to update a single attribute. The idea is attributes is passed in with only some values instantiated.
		 * That way you only update the values that have been set, all others are unchanged.
		 */
		public void UpdateAttributes (Attributes attributes)
		{
			baseAttributes.Strength = (attributes.Strength == 0) ? baseAttributes.Strength : attributes.Strength;
			baseAttributes.Dexterity = attributes.Dexterity == 0 ? baseAttributes.Dexterity : attributes.Dexterity;
			baseAttributes.Constitution = attributes.Constitution == 0 ? baseAttributes.Constitution : attributes.Constitution;
			baseAttributes.Intelligence = attributes.Intelligence == 0 ? baseAttributes.Intelligence : attributes.Intelligence;
			baseAttributes.Wisdom = attributes.Wisdom == 0 ? baseAttributes.Wisdom : attributes.Wisdom;
			baseAttributes.Charisma = attributes.Charisma == 0 ? baseAttributes.Charisma : attributes.Charisma;

			//Now modify by existing racial bonuses
			baseAttributes = baseAttributes - Race.BonusAttributes;
		}

		public CharacterSheet (string loadCharacter)
		{
			if (loadCharacter == "true") {
				//TODO Write load data, likely using SQLite
			} else {
				//Create empty dummy data
				CharacterName = "Jarom Brightblade";
				CharacterLevel = 2;
				ProficiencyBonus = 2;
				_playerAlignment = AlignmentInfo.Alignment.CHAEVIL;

				Race = new RaceHelper (RaceHelper.Race.DWARF);
				Class = new PlayerClass (PlayerClass.ClassName.MONK);

				baseAttributes = new Attributes {
					Strength = 15,
					Dexterity = 14,
					Constitution = 13,
					Intelligence = 11,
					Wisdom = 10,
					Charisma = 8
				};

				Background = new CharacterBackground ();
						
				Skills = new SkillsList (FinalAttributes, ProficiencyBonus);
			}

		}

		public void UpdateSkills (Attributes.AttributeName type)
		{
			Skills.UpdateSkillMod (type, FinalAttributes.GetModFromType (type));
		}

		public void SetRace (string raceSelected)
		{
			Race = new RaceHelper (raceSelected);
		}

		public void SetClass (string classSelected)
		{
			this.Class = new PlayerClass (classSelected);
		}
	}
}

