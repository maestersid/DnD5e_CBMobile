
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using DnD5e_CBMobile_Core;

namespace DnD5e_CBMobile_Android
{
	[Activity (Label = "@string/newCharacter")]			
	public class CharacterSheetActivity : Activity
	{

		private CharacterSheet testCharacter;

		protected override void OnCreate (Bundle bundle)
		{
		
			base.OnCreate (bundle);

			//Create dummy data
			testCharacter = new CharacterSheet (true);

			//setup Tab View
			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			SetContentView (Resource.Layout.CharacterSheetView);

		
		}
	}
}

