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

		public static List<string> GetClassList()
		{
			var items = new List<string>{"Paladin", "Wizard", "Monk"};
			return items;
		}

	}
}

