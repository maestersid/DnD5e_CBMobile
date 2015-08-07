
using DnD5e_CBMobile_Core;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using Android.Support.V4.View;

namespace DnD5e_CBMobile_Android
{
	[Activity (Label = "@string/characterSheet")]			
	public class CharacterSheetActivity : AppCompatActivity
	{

		private CharacterSheet testCharacter;

		protected override void OnCreate (Bundle bundle)
		{
		
			base.OnCreate (bundle);			

			//Create dummy data
			testCharacter = new CharacterSheet (true);

			SetContentView (Resource.Layout.charactersheet_main);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);
			SupportActionBar.Title = "Character Sheet";

			var viewPager = FindViewById<ViewPager> (Resource.Id.viewPager);
			SetupViewPagers (viewPager);

			var tabLayout = FindViewById<TabLayout> (Resource.Id.tabs);
			tabLayout.SetupWithViewPager (viewPager);
			//SetupCharacterData();

		}

		private void SetupViewPagers(ViewPager viewPager)
		{
			var adapter = new MyAdapter (SupportFragmentManager);
			adapter.AddFragment (new CharSheetOverviewFragment (), "Overview");
			adapter.AddFragment(new CharSheetSkillsFragment(), "Skills");
			viewPager.Adapter = adapter;

		}

		private void SetupCharacterData()
		{
//			var charNameText = FindViewById<EditText> (Resource.Id.charName);
//			charNameText.Text = testCharacter.CharacterName;
//			charNameText.TextChanged += OnCharacterNameChanged;
//
//			//Setup Class List Dropdown
//			Spinner classSpinner = FindViewById <Spinner> (Resource.Id.charClass);
//			classSpinner.ItemSelected += OnClassSelected;
//
//			var items = PlayerClass.GetClassList ();
//			var adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleSpinnerItem, items);
//			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
//			classSpinner.Adapter = adapter;
//
//			//Setup Attributes
//			EditText strText = FindViewById<EditText> (Resource.Id.strengthValue);
//			strText.TextChanged += OnAttributeChanged;

		}

		void OnAttributeChanged (object sender, Android.Text.TextChangedEventArgs e)
		{

		}

		void OnCharacterNameChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var textField = (EditText) sender;
			//testCharacter.CharacterName = textField.Text;
		}

		void OnClassSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			//update Selected Class on backend
			var first = spinner.SelectedItem;
			var res = spinner.GetItemAtPosition (e.Position);
		}
	}
}

