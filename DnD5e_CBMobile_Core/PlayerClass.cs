using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DnD5e_CBMobile_Core
{
	public class PlayerClass
	{

		private string _selectedClass = string.Empty;
		public string SelectedClass{ 
			get{
				return _selectedClass;
			} 
			set{
				_selectedClass = value;
			}
		}

		public static List<string> GetAllClasses()
		{
			var items = new List<string>{"Barbarian", "Bard", "Cleric", "Driud", 
										"Fighter", "Monk", "Paladin", "Ranger", 
										"Rogue", "Sorcerer", "Warlock","Wizard"};
			return items;
		}

	}
}

