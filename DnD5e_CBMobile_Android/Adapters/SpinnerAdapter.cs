using System;
using Android.Util;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using Android.App;

namespace DnD5e_CBMobile_Android
{
	public class SpinnerAdapter : BaseAdapter<string>
	{
		List<string> _items;
		Activity _context;
		public SpinnerAdapter (Activity context, List<string> items)
		{
			_items = items;
			_context = context;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public int GetPosition(string selected)
		{
			return _items.IndexOf (selected);
		}

		public override string this[int index] {  
			get { return _items[index]; }
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			var view = convertView;
			if(view == null)
			{
				view = _context.LayoutInflater.Inflate (Resource.Layout.spinner_item, null);
			}

			view.FindViewById<TextView> (Resource.Id.text).Text = _items[position];

			return view;
		}

		public override int Count {
			get {
				return _items.Count;
			}
		}
	}
}

