using NUnit.Framework;
using System;

namespace DnD5e_CBMobile_Core.Tests
{
	[TestFixture]
	public class AttributeTests
	{
		[Test]
		public void AddingUpdatesStrength()
		{
			Attributes baseAttr = new Attributes{ Strength = 10 };
			Attributes modifier = new Attributes{ Strength = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Strength, Is.EqualTo (12));
		}

		[Test]
		public void AddingUpdatesDex()
		{
			Attributes baseAttr = new Attributes{ Dexterity = 10 };
			Attributes modifier = new Attributes{ Dexterity = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Dexterity, Is.EqualTo (12));
		}

		[Test]
		public void AddingUpdatesConstitution()
		{
			Attributes baseAttr = new Attributes{ Constitution = 10 };
			Attributes modifier = new Attributes{ Constitution = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Constitution, Is.EqualTo (12));
		}

		[Test]
		public void AddingUpdatesInt()
		{
			Attributes baseAttr = new Attributes{ Intelligence = 10 };
			Attributes modifier = new Attributes{ Intelligence = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Intelligence, Is.EqualTo (12));
		}

		[Test]
		public void AddingUpdatesWisdom()
		{
			Attributes baseAttr = new Attributes{ Wisdom = 10 };
			Attributes modifier = new Attributes{ Wisdom = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Wisdom, Is.EqualTo (12));
		}

		[Test]
		public void AddingUpdatesCharisma()
		{
			Attributes baseAttr = new Attributes{ Charisma = 10 };
			Attributes modifier = new Attributes{ Charisma = 2 };
			var modified = baseAttr + modifier;
			Assert.That (modified.Charisma, Is.EqualTo (12));
		}

		[TestCase(7,-2)]
		[TestCase(8, -1)]
		[TestCase(9, -1)]
		[TestCase(10, 0)]
		[TestCase(11, 0)]
		[TestCase(12, 1)]
		[TestCase(13, 1)]
		[TestCase(18, 4)]
		[TestCase(14, 2)]
		[TestCase(16, 3)]
		public void ModifiersAreCorrectForAttributeValues(int attributeValue, int expectedModifier)
		{
			Attributes testAttributes = new Attributes { Strength = attributeValue };
			Assert.That (testAttributes.StrengthModifier, Is.EqualTo (expectedModifier));
		}

		[Test]
		public void HashCodeShouldAlsoWork()
		{
			var attributes1 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};
			var attributes2 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};

			Assert.That (attributes1.GetHashCode(), Is.EqualTo (attributes2.GetHashCode()));
		}

		[Test]
		public void AttributesAreEqualWhenAllValuesAreEqual()
		{
			var attributes1 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};
			var attributes2 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};

			Assert.That (attributes1, Is.EqualTo (attributes2));
		}

		[Test]
		public void AttributesAreEqualWhenValuesAreDifferent()
		{
			var attributes1 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};
			var attributes2 = new Attributes {
				Strength = 10,
				Dexterity = 11,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};

			Assert.That (attributes1, Is.Not.EqualTo (attributes2));
		}

		[Test]
		public void AttributesAreNotEqualToIntArrays()
		{
			var attributes1 = new Attributes {
				Strength = 10,
				Dexterity = 10,
				Constitution = 12,
				Intelligence = 15,
				Wisdom = 14,
				Charisma = 8
			};
			var attributes2 = new []{
				10,
				10,
				12,
				15,
				14,
				8
			};

			Assert.That (attributes2, Is.Not.EqualTo (attributes1));
		}
	}
}

