using System;
using UIKit;
using System.Collections.Generic;

namespace DnD5e_CBMobile_iOS
{
	public class PickerDataModel : UIPickerViewModel
	{
		private readonly string[] _data;
		public string SelectedItem { get; private set;}

		public PickerDataModel(List<string> info)
		{
			_data = info.ToArray ();
			SelectedItem = _data [0];
		}

		public PickerDataModel (List<string> info, string name)
		{
			_data = info.ToArray ();
			SelectedItem = name;
		}

		public override nint GetComponentCount(UIPickerView pickerView)
		{
			return 1;
		}

		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return _data.Length;
		}

		public override string GetTitle (UIPickerView pickerView, nint row, nint component)
		{
			return _data[row];
		}

		public override void Selected (UIPickerView pickerView, nint row, nint component)
		{
			SelectedItem = _data [row];
			OnPropertySelected (this, new EventArgs ());
		}

		public int IndexOf(string item)
		{
			return Array.IndexOf (_data, item);
		}

		public event EventHandler OnPropertySelected;
			
	}
}

