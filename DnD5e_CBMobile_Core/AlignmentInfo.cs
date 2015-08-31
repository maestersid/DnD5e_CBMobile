using System;
using System.Collections.Generic;

namespace DnD5e_CBMobile_Core
{
	/*
	 * The idea behind the Alignment class is it is a text entry only, but I want to control
	 * access within this class as I have UI controls (spinners) and internal data storage 
	 * that accesses it. Who knows if this is a good way to do it.
	 */
	public static class AlignmentInfo
	{
		public enum Alignment
		{
			LAWGOOD = 0, 
			LAWNEUTRAL = 1, 
			LAWEVIL = 2,
			NEUTRALGOOD = 3, 
			NEUTRAL = 4, 
			NEUTRALEVIL = 5, 
			CHAGOOD = 6, 
			CHANEUTRAL = 7, 
			CHAEVIL = 8
		}

		private static readonly List<string> alignments = new List<string>{"Lawful Good", "Lawful Neutral", "Lawful Evil",
			"Neutral Good", "Neutral", "Neutral Evil", 
			"Chaotic Good", "Chaotic Neutral", "Chaotic Evil"};

		public static string GetAlignment(Alignment index)
		{
			return alignments [(int)index];
		}

		public static AlignmentInfo.Alignment SetAlignment (string newAlignment)
		{
			return (Alignment)alignments.IndexOf (newAlignment);
		}

		public static List<string> GetAllAlignments ()
		{
			return alignments;
		}
	}
}

