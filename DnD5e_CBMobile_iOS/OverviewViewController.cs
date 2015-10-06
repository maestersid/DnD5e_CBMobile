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


			//Setup Class Info
			var classPicker = new UIPickerView (CGRect.Empty) {
				ShowSelectionIndicator = true
			};
			var classModel = new MyPickerModel (PlayerClass.GetAllClasses (), info.Class.Name);
			classModel.OnPropertySelected += (sender, args) => {
				classPickerText.Text = classModel.SelectedItem;
			};
			classPicker.Model = classModel;
			classPickerText.Text = classModel.SelectedItem;
			classPickerText.InputView = classPicker;

			var alignmentPicker = new UIPickerView (CGRect.Empty) {
				ShowSelectionIndicator = true
			};
			var alignmentModel = new MyPickerModel (AlignmentInfo.GetAllAlignments (), info.Alignment);
			alignmentModel.OnPropertySelected += (sender, args) => {
				charAlignment.Text = alignmentModel.SelectedItem;
			};
			alignmentPicker.Model = alignmentModel;
			charAlignment.Text = alignmentModel.SelectedItem;
			charAlignment.InputView = alignmentPicker;

			var backgroundPicker = new UIPickerView (CGRect.Empty) {
				ShowSelectionIndicator = true
			};
			var backgroundModel = new MyPickerModel (CharacterBackground.GetAllBackgrounds ());
			backgroundModel.OnPropertySelected += (sender, args) => {
				charBackground.Text = backgroundModel.SelectedItem;
			};
			backgroundPicker.Model = backgroundModel;
			charBackground.Text = backgroundModel.SelectedItem;
			charBackground.InputView = backgroundPicker;
		}
    }

}
