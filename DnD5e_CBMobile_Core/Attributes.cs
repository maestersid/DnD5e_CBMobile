using System;

namespace DnD5e_CBMobile_Core
{
	public class Attributes
	{
		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Constitution { get; set; }
		public int Intelligence {get; set;}
		public int Wisdom {get; set;}
		public int Charisma {get; set;}

		public int StrengthModifier { get{ return ConvertToModifier(Strength); }}
		public int DexterityModifier { get{ return ConvertToModifier(Dexterity); }}
		public int ConstitutionModifier{ get{ return ConvertToModifier(Constitution); }}
		public int IntelligenceModifier { get{ return ConvertToModifier(Intelligence); }}
		public int WisdomModifier { get{ return ConvertToModifier(Wisdom); }}
		public int CharismaModifier { get{ return ConvertToModifier(Charisma); }}

		private int ConvertToModifier (int attributeValue)
		{
			var baseLine = attributeValue - 10;
			if (baseLine < 0) {
				//because integer math is fun
				return  (baseLine -1) / 2;
			}
			return baseLine/2;
		}

		public override bool Equals (object obj)
		{
			var other = obj as Attributes;
			if (other == null) {
				return false;
			}
			return Strength == other.Strength &&
				Dexterity == other.Dexterity && 
				Constitution == other.Constitution &&
				Intelligence == other.Intelligence &&
				Wisdom == other.Wisdom &&
				Charisma == other.Charisma;
		}

		public override int GetHashCode ()
		{
			int hashCode = Strength;
			hashCode = hashCode * 33 + Dexterity;
			hashCode = hashCode * 33 + Constitution;
			hashCode = hashCode * 33 + Intelligence;
			hashCode = hashCode * 33 + Wisdom;
			hashCode = hashCode * 33 + Charisma;
			return hashCode;
		}

		public static Attributes operator +(Attributes op1, Attributes op2){
			return new Attributes {
				Strength = op1.Strength + op2.Strength,
				Dexterity = op1.Dexterity + op2.Dexterity,
				Constitution = op1.Constitution + op2.Constitution,
				Intelligence = op1.Intelligence + op2.Intelligence,
				Wisdom = op1.Wisdom + op2.Wisdom,
				Charisma = op1.Charisma + op2.Charisma
			};
		}
	}
}

