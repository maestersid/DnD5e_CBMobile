using DnD5e_CBMobile_Core;
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using ContactsUI;
using System.ComponentModel;
using System.IO;
using System.Drawing;

namespace DnD5e_CBMobile_iOS
{
	partial class OverviewViewController : UIViewController
	{
        CharacterSheet info;
		    
		public OverviewViewController (IntPtr handle) : base (handle)
		{		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            info = new CharacterSheet("false");

            SetupCharacterData();

        }

        private void SetupCharacterData()
		{
			charName.Text = info.CharacterName;
			charLevel.Text = info.CharacterLevel + "";

			SetupPickerField(RaceHelper.GetAllRaces (), info.Race.Name, racePickerText);
			SetupPickerField(PlayerClass.GetAllClasses (), info.Class.Name, classPickerText);
			SetupPickerField (AlignmentInfo.GetAllAlignments (), info.Alignment, charAlignment);
			SetupPickerField (CharacterBackground.GetAllBackgrounds (), info.Background.GetBackground (), charBackground);
			/*
			//Set Race Info
			var racePicker = new UIPickerView (CGRect.Empty);
			var model = new MyPickerModel (RaceHelper.GetAllRaces (), info.Race.Name);
			model.OnPropertySelected += (object sender, EventArgs args) => 
			{
				racePickerText.Text = model.SelectedItem;
			};
			racePicker.Model = model;
			racePicker.Select (model.IndexOf (info.Race.Name), 0, false);

			racePickerText.Text = model.SelectedItem;
			racePickerText.InputView = racePicker;

			var toolbar = new UIToolbar (new RectangleF (0.0f, 0.0f, 50.0f, 44.0f));

			var myButton = new UIBarButtonItem (UIBarButtonSystemItem.Done, delegate {
				this.racePickerText.ResignFirstResponder ();
			});

			toolbar.Items = new UIBarButtonItem[] {
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
				myButton
			};

			racePickerText.InputAccessoryView = toolbar;
			*/
		}

		void SetupPickerField(List<string> data, string selected, UITextField textField)
		{
			var picker = new UIPickerView (CGRect.Empty);
			var model = new PickerDataModel (data, selected);
			model.OnPropertySelected += (object sender, EventArgs args) => 
			{
				textField.Text = model.SelectedItem;
			};

			picker.Model = model;
			picker.Select (model.IndexOf (selected), 0, false);
			textField.Text = model.SelectedItem;

			var toolbar = new UIToolbar (new RectangleF (0.0f, 0.0f, 50.0f, 44.0f));

			var myButton = new UIBarButtonItem (UIBarButtonSystemItem.Done, delegate {
				textField.ResignFirstResponder ();
			});

			toolbar.Items = new UIBarButtonItem[] {
				new UIBarButtonItem (UIBarButtonSystemItem.FlexibleSpace),
				myButton
			};

			textField.InputView = picker;
			textField.InputAccessoryView = toolbar;
		}
    }

}
