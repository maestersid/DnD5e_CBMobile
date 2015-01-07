using System;
using NUnit.Framework;

namespace DnD5e_CBMobile_Core.Tests
{
	[TestFixture]
	public class CharacterTests
	{
		[Test]
		public void CharacterAttributesAddsRacialModifiersToBaseAttributes()
		{
			var character = new CharacterSheet ();
			var race = new Race{ BonusAttributes = new Attributes { Strength = 2, Charisma = 1 } };
			character.Race = race;
			var attributes = new Attributes {
				Strength = 15,
				Dexterity = 14,
				Constitution = 13,
				Intelligence = 12,
				Wisdom = 10,
				Charisma = 8
			};
			character.SetBaseAttributes (attributes);
			Assert.That (character.FinalAttributes, Is.EqualTo (race.BonusAttributes + attributes));
		}
	}
}

