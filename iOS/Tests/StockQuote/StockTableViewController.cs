using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SimplyMobile.Plugins.StockView;

namespace StockQuote
{
	public partial class StockTableViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public StockTableViewController ()
			: base (UserInterfaceIdiomIsPhone ? "StockTableViewController_iPhone" : "StockTableViewController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

//			this.tableView.Delegate = new StockTableDelegate ();

            StockViewModel.StockModel.StockQuotes.Bind(this.tableView);
		}
	}
}

