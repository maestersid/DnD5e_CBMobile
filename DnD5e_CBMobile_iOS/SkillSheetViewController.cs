using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DnD5e_CBMobile_iOS
{
	partial class SkillSheetViewController : UITableViewController
	{
		public SkillSheetViewController (IntPtr handle) : base (handle)
		{
            this.Title = "Skill List";
		}
	}
}
