
using Android.App;
using Android.OS;
using Android.Views;
using System.Collections.Generic;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace DnD5e_CBMobile_Android
{
	public class ViewPagerAdapter : Android.Support.V4.App.FragmentPagerAdapter
	{
		List<Fragment> fragments = new List<Fragment> ();
		List<string> fragmentTitles = new List<string> ();

		public ViewPagerAdapter (FragmentManager fm) : base (fm)
		{
		}

		public void AddFragment (Fragment fragment, string title) 
		{
			fragments.Add(fragment);
			fragmentTitles.Add(title);
		}

		public override Fragment GetItem(int position) 
		{
			return fragments [position];
		}

		public override int Count {
			get { return fragments.Count; }
		}

		public override Java.Lang.ICharSequence GetPageTitleFormatted (int position)
		{
			return new Java.Lang.String (fragmentTitles [position]);
		}

	}
}

