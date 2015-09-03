using System;
using Android.Views;
using Android.OS;
using Android.Widget;
using Android.Support.V7;
using DnD5e_CBMobile_Core;
using Android.Views.InputMethods;


namespace DnD5e_CBMobile_Android
{
	public class CharSheetOverviewFragment : Android.Support.V4.App.Fragment
	{

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var root = inflater.Inflate (Resource.Layout.fragment_charsheet_overview, container, false);

			//Create dummy data
			SetupCharacterData (root);
			SetupCharacterAttributes (root);

			return root;
		}

		#region Character Data

		private void SetupCharacterData (View view)
		{

			var charNameText = view.FindViewById<EditText> (Resource.Id.charName);
			charNameText.Text = ((CharacterSheetActivity)this.Activity).CharacterInformation.CharacterName;
			charNameText.TextChanged += (sender, e) => {
				if (e.Text != null) {
					((CharacterSheetActivity)this.Activity).CharacterInformation.CharacterName = (string)e.Text;
				}
			};

			var charLevel = view.FindViewById<EditText> (Resource.Id.charLevel);
			charLevel.Text = ((CharacterSheetActivity)this.Activity).CharacterInformation.CharacterLevel + "";
			charLevel.TextChanged += (sender, e) => {

				var value = (EditText)sender;
				int val; 
				int.TryParse (value.Text, out val);
				((CharacterSheetActivity)this.Activity).CharacterInformation.CharacterLevel = val;
			};

			//Setup Races
			Spinner racesSpinner = view.FindViewById <Spinner> (Resource.Id.charRace);

			var items = RaceHelper.GetAllRaces ();
			var adapter = new SpinnerAdapter (this.Activity, items);
			racesSpinner.Adapter = adapter;
			racesSpinner.ItemSelected += OnRaceSelected;

			string currentRace = ((CharacterSheetActivity)this.Activity).CharacterInformation.Race.Name;
			racesSpinner.SetSelection (adapter.GetPosition (currentRace));

			//Setup Class List Dropdown
			Spinner classSpinner = view.FindViewById <Spinner> (Resource.Id.charClass);
			var classes = PlayerClass.GetAllClasses ();
			var classAdapter = new SpinnerAdapter (this.Activity, classes);
			classSpinner.Adapter = classAdapter;
			classSpinner.ItemSelected += OnClassSelected;

			string currentClass = ((CharacterSheetActivity)this.Activity).CharacterInformation.Class.Name;
			classSpinner.SetSelection (classAdapter.GetPosition (currentClass));

			//Setup Alignment
			Spinner alignmentSpinner = view.FindViewById <Spinner> (Resource.Id.charAlignment);
			var alignments = AlignmentInfo.GetAllAlignments ();
			var alignmentAdapter = new SpinnerAdapter (this.Activity, alignments);
			alignmentSpinner.Adapter = alignmentAdapter; 	//Set Spinner adapter needs to happen before we set preselected data
			alignmentSpinner.ItemSelected += OnAlignmentSelected;
			//Set selected alignment data
			string currentAlignment = ((CharacterSheetActivity)this.Activity).CharacterInformation.Alignment;
			alignmentSpinner.SetSelection (alignmentAdapter.GetPosition (currentAlignment));

			//Setup Background
			//TODO this still needs to be set on the back end beyond just a string
			Spinner backgroundSpinner = view.FindViewById <Spinner> (Resource.Id.charBackground);
			backgroundSpinner.ItemSelected += OnBackgroundSelected;
			var backgrounds = CharacterBackground.GetAllBackgrounds ();
			var backgroundAdapter = new SpinnerAdapter (this.Activity, backgrounds);
			backgroundSpinner.Adapter = backgroundAdapter;

		}

		void OnRaceSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			var spinner = (Spinner)sender;
			((CharacterSheetActivity)Activity).CharacterInformation.SetRace (spinner.GetItemAtPosition (e.Position) + "");
		}

		void OnClassSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			var spinner = (Spinner)sender;
			((CharacterSheetActivity)Activity).CharacterInformation.SetClass (spinner.GetItemAtPosition (e.Position) + "");

		}

		void OnAlignmentSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			var spinner = (Spinner)sender;
			((CharacterSheetActivity)Activity).CharacterInformation.Alignment = spinner.GetItemAtPosition (e.Position).ToString ();
		}

		void OnBackgroundSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			//To be implemented once Background becomes important
		}

		#endregion

		#region Attributes

		/* 
		 * TODO Create a Generic EditText Class for Attribute, 
		 * self store identity and then attribute event can be single source;
		*/

		void SetupCharacterAttributes (View view)
		{
			Attributes attributes = ((CharacterSheetActivity)this.Activity).CharacterInformation.FinalAttributes;

			//Strength
			var strValue = view.FindViewById<EditText> (Resource.Id.strengthValue);
			strValue.Text = attributes.Strength + "";
			strValue.TextChanged += OnStrengthChanged;

			var strMod = view.FindViewById<TextView> (Resource.Id.strengthMod);
			strMod.Text = attributes.StrengthModifier + "";

			//Dexterity
			var dexValue = view.FindViewById<EditText> (Resource.Id.dexterityValue);
			dexValue.Text = attributes.Dexterity + "";
			dexValue.TextChanged += OnDexterityChanged;

			var dexMod = view.FindViewById<TextView> (Resource.Id.dexterityMod);
			dexMod.Text = attributes.DexterityModifier + "";

			//Constitution
			var conValue = view.FindViewById<EditText> (Resource.Id.constitutionValue);
			conValue.Text = attributes.Constitution + "";
			conValue.TextChanged += OnConstitutionChanged;

			var conMod = view.FindViewById<TextView> (Resource.Id.constitutionMod);
			conMod.Text = attributes.ConstitutionModifier + "";

			//Intelligence
			var intValue = view.FindViewById<EditText> (Resource.Id.intValue);
			intValue.Text = attributes.Intelligence + "";
			intValue.TextChanged += OnIntelligenceChanged;

			var intMod = view.FindViewById<TextView> (Resource.Id.intMod);
			intMod.Text = attributes.IntelligenceModifier + "";

			//Wisdom
			var wisValue = view.FindViewById<EditText> (Resource.Id.wisdomValue);
			wisValue.Text = attributes.Wisdom + "";
			wisValue.TextChanged += OnWisdomChanged;

			var wisMod = view.FindViewById<TextView> (Resource.Id.wisdomMod);
			wisMod.Text = attributes.WisdomModifier + "";

			//Charisma
			var chaValue = view.FindViewById<EditText> (Resource.Id.charismaValue);
			chaValue.Text = attributes.Charisma + "";
			chaValue.TextChanged += OnCharismaChanged;

			var chaMod = view.FindViewById<TextView> (Resource.Id.charismaMod);
			chaMod.Text = attributes.CharismaModifier + "";

		}


		/*
		 * Text changed setter methods for all 6 attributes to also update mod values
		 */
		void OnStrengthChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;
			int val; 
			int.TryParse (view.Text, out val);

			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Strength = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.strengthMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.StrengthModifier + "";

			character.UpdateSkills (Attributes.AttributeName.STR);
		}

		void OnDexterityChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;

			int val; 
			int.TryParse (view.Text, out val);
			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Dexterity = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.dexterityMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.DexterityModifier + "";
			character.UpdateSkills (Attributes.AttributeName.DEX);
		}

		void OnConstitutionChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;
			int val; 
			int.TryParse (view.Text, out val);

			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Constitution = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.constitutionMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.ConstitutionModifier + "";
		}

		void OnWisdomChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;
			int val; 
			int.TryParse (view.Text, out val);

			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Wisdom = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.wisdomMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.WisdomModifier + "";
			character.UpdateSkills (Attributes.AttributeName.WIS);
		}

		void OnIntelligenceChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;
			int val; 
			int.TryParse (view.Text, out val);

			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Intelligence = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.intMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.IntelligenceModifier + "";
			character.UpdateSkills (Attributes.AttributeName.INT);
		}

		void OnCharismaChanged (object sender, Android.Text.TextChangedEventArgs e)
		{
			var view = (EditText)sender;
			int val; 
			int.TryParse (view.Text, out val);

			CharacterSheet character = ((CharacterSheetActivity)Activity).CharacterInformation;
			character.UpdateAttributes (
				new Attributes { Charisma = val }
			);

			var mod = Activity.FindViewById<TextView> (Resource.Id.charismaMod);
			mod.Text = ((CharacterSheetActivity)Activity).CharacterInformation.FinalAttributes.CharismaModifier + "";
			character.UpdateSkills (Attributes.AttributeName.CHA);
		}

		#endregion
	}
}

