using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;

namespace DnD5e_CBMobile_Core
{
	public class SkillsList : ICollection<Skill>
	{
		private List<Skill> _skills;

		private List<string> _skilLNames = new List<string> {"Acrobatics", "Animal Handling", "Arcana", "Althetics",
			"Deception", "History", "Insight", "Intimidation", 
			"Investigation", "Medicine", "Nature", "Perception", 
			"Performance", "Persuasion", "Religion", "Sleight of Hand", 
			"Stealth", "Survival"
		};

		private List<string> strSkills = new List<string> {
			"Athletics",
		};

		private List<string> dexSkills = new List<string> {
			"Acrobatics", "Sleight of Hand", "Stealth"
		};

		private List<string> wisSkills = new List<string> {
			"Animal Handling", "Medicine", "Insight", "Perception", "Survival"
		};

		private List<string> intSkills = new List<string> {
			"Arcana", "History", "Investigation", "Nature", "Religion"
		};

		private List<string> chaSkills = new List<string> {
			"Deception", "Intimidation", "Performance", "Persuasion"
		};

		public SkillsList (Attributes attributes, int proficiency)
		{
			_skills = new List<Skill> ();

			SetupAttributes (strSkills, Attributes.AttributeName.STR, attributes.StrengthModifier, proficiency);
			SetupAttributes (dexSkills, Attributes.AttributeName.DEX, attributes.DexterityModifier, proficiency);
			SetupAttributes (wisSkills, Attributes.AttributeName.WIS, attributes.WisdomModifier, proficiency);
			SetupAttributes (intSkills, Attributes.AttributeName.INT, attributes.IntelligenceModifier, proficiency);
			SetupAttributes (chaSkills, Attributes.AttributeName.CHA, attributes.CharismaModifier, proficiency);
		}

		void SetupAttributes (List<string> skillList, Attributes.AttributeName modType, int mod, int proficiency)
		{

			foreach (string str in skillList) {
				Skill skill = new Skill ();
				skill.Name = str;
				skill.IsProficient = false;
				skill.ProficiencyValue = proficiency;
				skill.ModType = modType;
				skill.ModValue = mod;
				_skills.Add (skill);
			}
		}

		public void UpdateSkillMod (Attributes.AttributeName type, int mod)
		{
			foreach(Skill skill in _skills)
			{				
				if(skill.ModType == type)
				{
					skill.ModValue = mod;
				}
			}
		}

		public Skill this [int index] {
			get {
				return _skills [index];
			}
		}

		#region ICollection implementation

		public void Add (Skill item)
		{
			_skills.Add (item);
		}

		public void Clear ()
		{
			_skills.Clear ();
		}

		public bool Contains (Skill item)
		{
			return _skills.Contains (item);
		}

		public void CopyTo (Skill[] array, int arrayIndex)
		{
			_skills.CopyTo (array, arrayIndex);
		}

		public bool Remove (Skill item)
		{
			return _skills.Remove (item);
		}

		public int Count {
			get {
				return _skills.Count;
			}
		}

		public bool IsReadOnly {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion

		#region IEnumerable implementation

		public IEnumerator<Skill> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		#endregion

		#region IEnumerable implementation

		IEnumerator IEnumerable.GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

