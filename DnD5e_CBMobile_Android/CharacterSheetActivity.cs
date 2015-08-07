
using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using DnD5e_CBMobile_Core;
using Android.Widget;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

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

			//SetupCharacterData();

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

