using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{
	public class CharacterBackground
	{
		public CharacterBackground ()
		{
		}

		public static List<string> GetAllBackgrounds ()
		{
			var items = new List<string>{"Acolyte", "Charlatan", "Criminal", "Entertainer",
				"Folk Hero", "Guild Artisan", "Hermit", "Noble",
				"Outlander", "Sage", "Sailor", "Soldier", "Urchin"};
			
			return items;
		}
	}
}

