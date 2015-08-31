using System;
using System.Collections.Generic;
using System.Xml;

namespace DnD5e_CBMobile_Core
{

	public class RaceHelper
	{
		public enum Race
		{
			HUMAN = 0,
			DWARF,
			ELF,
			HALFING,
			DRAGONBORN,
			GNOME,
			HALFELF,
			HALFORC,
			TIEFLING
		}
			
		public Attributes BonusAttributes { get; set; }
		public string Name { get; set; }

		private static readonly List<string> AllRaces = new List<string>{"Human", "Dwarf", "Elf" , "Halfing", 
			"Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling" };

		public RaceHelper(Race selectedRace)
		{
			Name = AllRaces [(int)selectedRace];

			//This is temporary hardcoded until I figure out how to deal with this mess
			BonusAttributes = new Attributes { Strength = 2, Wisdom = 2 };
		}

		public RaceHelper(string selectedRace)
		{
			Name = selectedRace;

			//This is temporary hardcoded until I figure out how to deal with this mess
			BonusAttributes = new Attributes { Strength = 2, Wisdom = 2 };
		}

		public static List<string> GetAllRaces ()
		{
			return AllRaces;
		}


	}
}

