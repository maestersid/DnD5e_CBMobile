
using Android.OS;
using Android.Views;
using Android.Widget;
using DnD5e_CBMobile_Core;

namespace DnD5e_CBMobile_Android
{
	public class CharSheetSkillsFragment : Android.Support.V4.App.Fragment
	{

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var root = inflater.Inflate (Resource.Layout.fragment_charsheet_skills, container, false);

			ListView view = root.FindViewById<ListView> (Resource.Id.skillsList);

			var skills = ((CharacterSheetActivity)this.Activity).CharacterInformation.Skills;
			view.Adapter = new SkillDetailAdapter (this.Activity, skills);

			return root;

		}

	}
}

