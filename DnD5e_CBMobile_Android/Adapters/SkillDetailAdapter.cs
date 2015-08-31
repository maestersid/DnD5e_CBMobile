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
		private SkillsList _skills;
		private Activity _context;

		public SkillDetailAdapter (Activity context, SkillsList skills)
		{
			_skills = skills;
			_context = context;
		}


		public override Skill this [int index] {
			get {
				return _skills [index];
			}
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var view = _context.LayoutInflater.Inflate (Resource.Layout.skillDisplayRow, parent, false);

			var name = view.FindViewById<TextView> (Resource.Id.skillName);
			var modValue = view.FindViewById<TextView> (Resource.Id.modValue);
			var proficient = view.FindViewById<CheckBox> (Resource.Id.isTrained);
			var skillMod = view.FindViewById<TextView> (Resource.Id.totalValue);

			name.Text = _skills [position].Name;
			modValue.Text = _skills [position].ModValue + "";
			proficient.Checked = _skills [position].IsProficient;

			proficient.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) => {
				_skills [position].IsProficient = e.IsChecked;
				skillMod.Text = _skills [position].TotalValue + "";
			};

			skillMod.Text = _skills [position].TotalValue + "";

			return view;
		}

		public override int Count {
			get {
				return _skills.Count;
			}
		}

	}
}

