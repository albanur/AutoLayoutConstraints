using System;
using UIKit;

namespace AutoLayoutConstraints
{
    public class CodedViewController : UIViewController
    {
        private UILabel label;

        public CodedViewController()
        {
            TabBarItem.Title = "Coded";
            TabBarItem.Image = UIImage.FromBundle("Square");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            label = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "Coded UI",
                Font = UIFont.PreferredTitle2,
            };

            View.AddSubviews(label);

            View.BackgroundColor = UIColor.White;

            var guide = View.SafeAreaLayoutGuide;

            NSLayoutConstraint.ActivateConstraints(new[]
            {
                label.CenterXAnchor.ConstraintEqualTo(guide.CenterXAnchor),
                label.CenterYAnchor.ConstraintEqualTo(guide.CenterYAnchor),
            });
        }
    }
}
