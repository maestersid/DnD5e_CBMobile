
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using DnD5e_CBMobile_Core;
using Android.Views;
using Android.Views.InputMethods;

namespace DnD5e_CBMobile_Android
{
	[Activity (Label = "@string/characterSheet")]			
	public class CharacterSheetActivity : AppCompatActivity
	{
		//Stores all loaded character info
		public CharacterSheet CharacterInformation;

		protected override void OnCreate (Bundle bundle)
		{
			
			base.OnCreate (bundle);

			//Load character data
			var loadCharacter = Intent.GetStringExtra ("loadCharacter");

			CharacterInformation = new CharacterSheet (loadCharacter);

			SetContentView (Resource.Layout.charactersheet_main);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);
			SupportActionBar.Title = "Character Sheet";

			var viewPager = FindViewById<ViewPager> (Resource.Id.viewPager);
			SetupViewPagers (viewPager);

			var tabLayout = FindViewById<TabLayout> (Resource.Id.tabs);
			tabLayout.SetupWithViewPager (viewPager);
		
		}

		private void SetupViewPagers(ViewPager viewPager)
		{
			var adapter = new ViewPagerAdapter (SupportFragmentManager);
			adapter.AddFragment (new CharSheetOverviewFragment (), "Overview");
			adapter.AddFragment(new CharSheetSkillsFragment(), "Skills");
			viewPager.Adapter = adapter;

		}

	}
}

