
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DnD5e_CBMobile_Android
{
	[Activity (Label = "@string/newCharacter")]			
	public class CharacterSheetActivity : Activity
	{
		private CharacterSheet

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.CharacterSheetView);
		}
	}
}

