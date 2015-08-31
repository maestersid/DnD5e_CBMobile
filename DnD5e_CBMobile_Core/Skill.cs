using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{
	public class Skill
	{
		public string Name { get; set; }

		public Attributes.AttributeName ModType { get; set; }

		public int ModValue { get; set; }

		public bool IsProficient { get; set; }

		public int ProficiencyValue { get; set; }

		public int TotalValue {
			get {
				return ((IsProficient) ? ProficiencyValue : 0) + ModValue;
			}
		}

	}
}

