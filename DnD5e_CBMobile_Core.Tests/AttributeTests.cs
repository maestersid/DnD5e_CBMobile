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
	}
}

