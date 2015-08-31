using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DnD5e_CBMobile_Core
{
	public class PlayerClass
	{

		public enum ClassName
		{
			BARBARIAN = 0,
			BARD,
			CLERIC,
			DRUID,
			FIGHTER,
			MONK,
			PALADIN,
			RANGER,
			ROGUE,
			SORCERER,
			WARLOCK,
			WIZARD
		}

		public string Name{ get; set; }

		private static readonly List<string> _allClassNames = new List<string> {
			"Barbarian", "Bard", "Cleric", "Driud", "Fighter", 
			"Monk", "Paladin", "Ranger", "Rogue", "Sorcerer",
			"Warlock", "Wizard"
		};

		public PlayerClass ()
		{
		}

		public PlayerClass (ClassName classSelected)
		{
			Name = _allClassNames [(int)classSelected];
		}

		public PlayerClass (string className)
		{
			Name = className;
		}

		public static List<string> GetAllClasses ()
		{
			return _allClassNames;
		}
	}
}

