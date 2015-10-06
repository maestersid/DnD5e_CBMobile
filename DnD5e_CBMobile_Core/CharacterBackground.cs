using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{
	public class CharacterBackground
	{
		private static readonly List<string> backgrounds = new List<string>{"Acolyte", "Charlatan", "Criminal", "Entertainer",
			"Folk Hero", "Guild Artisan", "Hermit", "Noble",
			"Outlander", "Sage", "Sailor", "Soldier", "Urchin"};

		public CharacterBackground ()
		{
		}

		public static List<string> GetAllBackgrounds ()
		{
			return backgrounds;
		}

		public string GetBackground()
		{
			return backgrounds [0];
		}
	}
}

