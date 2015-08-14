using System;
using Android.Views;
using Android.OS;
using Android.Widget;
using Android.Support.V7;
using DnD5e_CBMobile_Core;


namespace DnD5e_CBMobile_Android
{
	public class CharSheetOverviewFragment : Android.Support.V4.App.Fragment
	{
		public CharSheetOverviewFragment ()
		{
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var root = inflater.Inflate (Resource.Layout.fragment_charsheet_overview, container, false);

			//Create dummy data
			SetupCharacterData(root);
			//SetupCharacterAttributes (root);

			return root;
		}

		private void SetupCharacterData(View view)
		{

			var charNameText = view.FindViewById<EditText>(Resource.Id.charName);
			charNameText.Text = ((CharacterSheetActivity)this.Activity).TestCharacter.CharacterName;

			var charLevel = view.FindViewById<EditText> (Resource.Id.charLevel);
			charLevel.Text = ((CharacterSheetActivity)this.Activity).TestCharacter.CharacterLevel + "";

			//Setup Races
			Spinner racesSpinner = view.FindViewById <Spinner> (Resource.Id.charRace);
			racesSpinner.ItemSelected += OnRaceSelected;

			var items = Race.GetAllRaces ();
			var adapter = new ArrayAdapter<string> (this.Activity, Resource.Layout.spinner_item, items);
			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			racesSpinner.Adapter = adapter;

			//Setup Class List Dropdown
			Spinner classSpinner = view.FindViewById <Spinner> (Resource.Id.charClass);
			classSpinner.ItemSelected += OnClassSelected;
			
			var classes = PlayerClass.GetAllClasses ();
			var classAdapter = new ArrayAdapter<string> (this.Activity, Resource.Layout.spinner_item, classes);
			classAdapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			classSpinner.Adapter = classAdapter;

			//Setup Alignment
			Spinner playerAlignment = view.FindViewById <Spinner> (Resource.Id.charAlignment);
			playerAlignment.ItemSelected += OnAlignmentSelected;

			var alignments = Alignment.GetAllAlignments ();
			var alignmentAdapter = new ArrayAdapter<string> (this.Activity, Resource.Layout.spinner_item, alignments);
			alignmentAdapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			playerAlignment.Adapter = alignmentAdapter;

			//Setup Background
			Spinner backgroundSpinner = view.FindViewById <Spinner> (Resource.Id.charBackground);
			backgroundSpinner.ItemSelected += OnBackgroundSelected;

			var backgrounds = CharacterBackground.GetAllBackgrounds ();
			var backgroundAdapter = new ArrayAdapter<string> (this.Activity, Resource.Layout.spinner_item, backgrounds);
			backgroundAdapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			backgroundSpinner.Adapter = backgroundAdapter;

		}

		void OnRaceSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			//throw new NotImplementedException ();
		}

		void OnClassSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			//throw new NotImplementedException ();
		}

		void OnAlignmentSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			//throw new NotImplementedException ();
		}

		void OnBackgroundSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			//throw new NotImplementedException ();
		}
	}
}

