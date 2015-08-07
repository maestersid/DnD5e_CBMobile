using System;
using Android.App;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.Collections;
using Android.Content;
using Android.Widget;

namespace DnD5e_CBMobile_Android
{
	
	[Activity (MainLauncher = true, Theme = "@style/MainAppTheme")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.start_page);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);

			SupportActionBar.Title = "D&D Character Creator";

		}

		//Setup my Menu
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.home, menu);
			return base.OnCreateOptionsMenu (menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Resource.Id.new_char:
				var intent = new Intent (this, typeof(CharacterSheetActivity));
				StartActivity (intent);
				return true;
			case Resource.Id.load_char:
				Toast.MakeText (this, "Load Character Pressed", ToastLength.Short).Show ();
				return true;
			}
			return true;
		}
			
	}
}


