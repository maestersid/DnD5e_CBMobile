using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{

	public class Race
	{
		public Attributes BonusAttributes { get; set; }
		public string Name { get; set; }

		public static List<string> GetAllRaces()
		{
			var items = new List<string>{"Human", "Dwarf", "Elf", "Halfing", 
							"Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling"};
			return items;
		}
	}
}

