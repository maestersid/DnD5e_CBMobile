using System;
using Android.Views;
using Android.OS;

namespace DnD5e_CBMobile_Android
{
	public class CharSheetOverviewFragment : Android.Support.V4.App.Fragment
	{
		public CharSheetOverviewFragment ()
		{
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate (Resource.Layout.fragment_charsheet_overview, container, false);
		}
	}
}

