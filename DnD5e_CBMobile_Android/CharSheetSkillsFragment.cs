
using Android.OS;
using Android.Views;

namespace DnD5e_CBMobile_Android
{
	public class CharSheetSkillsFragment : Android.Support.V4.App.Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			return inflater.Inflate (Resource.Layout.fragment_charsheet_skills, container, false);
		}
	}
}

