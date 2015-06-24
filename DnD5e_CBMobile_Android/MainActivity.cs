using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;


namespace DnD5e_CBMobile_Android
{
	
	[Activity (Label = "DnD5e_CBMobile_Android", MainLauncher = true, 
		Icon = "@drawable/icon", Theme = "@style/HomePageTheme")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.StartPage);

			FloatingActionButton newCharacterBtn = FindViewById<FloatingActionButton> (Resource.Id.newCharacterBtn);
			newCharacterBtn.Click += (sender, e) =>
			{
				var intent = new Intent(this, typeof(CharacterSheetActivity));
				StartActivity(intent);
			};

		}
			
	}
}


