﻿using System;

using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace DnD5e_CBMobile_Android
{

	[Activity (Label = "DnD5e_CBMobile_Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.StartPage);

			Button newCharacterBtn = FindViewById<Button> (Resource.Id.NewCharacterBtn);


			newCharacterBtn.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(CharacterSheetActivity));
				StartActivity(intent);
			};

		}
			
	}
}


