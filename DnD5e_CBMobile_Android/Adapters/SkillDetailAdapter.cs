using System;
using Android.Util;
using Android.Widget;
using DnD5e_CBMobile_Core;
using System.Collections.Generic;
using Android.Views;
using Android.App;
using Android.Support.V7.Internal.Widget;
using System.Runtime.InteropServices;

namespace DnD5e_CBMobile_Android
{
	public class SkillDetailAdapter : BaseAdapter<Skill>
	{
		
		private Activity _context;

		public SkillDetailAdapter (Activity context)
		{
			_context = context;
		}


		public override Skill this [int index] {
			get {
				return ((CharacterSheetActivity)_context).CharacterInformation.Skills [index];
			}
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = _context.LayoutInflater.Inflate (Resource.Layout.skillDisplayRow, parent, false);
			CharacterSheet sheet = ((CharacterSheetActivity)_context).CharacterInformation;

			var name = view.FindViewById<TextView> (Resource.Id.skillName);
			var modValue = view.FindViewById<TextView> (Resource.Id.modValue);
			var proficient = view.FindViewById<CheckBox> (Resource.Id.isTrained);
			var skillMod = view.FindViewById<TextView> (Resource.Id.totalValue);

			name.Text = sheet.Skills [position].Name;
			modValue.Text = sheet.Skills  [position].ModValue + "";
			proficient.Checked = sheet.Skills  [position].IsProficient;

			proficient.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) => {
				
				sheet.Skills[position].IsProficient = e.IsChecked;
				skillMod.Text = sheet.Skills [position].TotalValue + "";
			};

			skillMod.Text = sheet.Skills  [position].TotalValue + "";

			return view;
		}

		public override int Count {
			get {
				return ((CharacterSheetActivity)_context).CharacterInformation.Skills.Count;
			}
		}

	}
}

