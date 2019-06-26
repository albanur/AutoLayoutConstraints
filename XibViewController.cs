using System;

using UIKit;

namespace AutoLayoutConstraints
{
    public partial class XibViewController : UIViewController
    {
        public XibViewController() : base("XibViewController", null)
        {
            TabBarItem.Title = "XIB";
            TabBarItem.Image = UIImage.FromBundle("Circle");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

