using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{
	public class Alignment
	{
		public Alignment ()
		{
		}

		public static List<string> GetAllAlignments ()
		{
			var items = new List<string>{"Lawful Good", "Lawful Neutral", "Lawful Evil",
										"Neutral Good", "Neutral", "Neutral Evil", 
										"Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};
			return items;
		}
	}
}

