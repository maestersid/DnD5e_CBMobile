// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DnD5e_CBMobile_iOS
{
	[Register ("OverviewViewController")]
	partial class OverviewViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField charAlignment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField charBackground { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField charLevel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField charName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField classPickerText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField racePickerText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (charAlignment != null) {
				charAlignment.Dispose ();
				charAlignment = null;
			}
			if (charBackground != null) {
				charBackground.Dispose ();
				charBackground = null;
			}
			if (charLevel != null) {
				charLevel.Dispose ();
				charLevel = null;
			}
			if (charName != null) {
				charName.Dispose ();
				charName = null;
			}
			if (classPickerText != null) {
				classPickerText.Dispose ();
				classPickerText = null;
			}
			if (racePickerText != null) {
				racePickerText.Dispose ();
				racePickerText = null;
			}
		}
	}
}
