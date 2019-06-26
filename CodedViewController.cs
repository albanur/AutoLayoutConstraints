using System;
using UIKit;

namespace AutoLayoutConstraints
{
    public class CodedViewController : UIViewController
    {
        private UILabel titleLabel;
        private UIImageView plusImage;
        private UILabel text1Label;
        private UILabel text2Label;
        private UILabel text3Label;
        private UIButton button;
        private UISlider slider;

        public CodedViewController()
        {
            TabBarItem.Title = "Coded";
            TabBarItem.Image = UIImage.FromBundle("Square");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            titleLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "Title",
                Font = UIFont.PreferredTitle1,
                TextAlignment = UITextAlignment.Center,
            };

            plusImage = new UIImageView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Image = UIImage.FromBundle("Plus"),
                ContentMode = UIViewContentMode.ScaleAspectFit,
            };

            text1Label = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "Subtitle",
                Font = UIFont.PreferredTitle2,
                TextAlignment = UITextAlignment.Left,
            };

            text2Label = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "Very long text",
                Font = UIFont.PreferredBody,
                TextAlignment = UITextAlignment.Left,
            };

            text3Label = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Text = "Text",
                Font = UIFont.PreferredFootnote,
                TextAlignment = UITextAlignment.Left,
            };

            button = new UIButton(UIButtonType.RoundedRect)
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = UIColor.LightGray,
            };
            button.SetTitle("Button", UIControlState.Normal);

            slider = new UISlider
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                MinValue = 0,
                MaxValue = 1,
                Value = 0.5f,
            };

            View.AddSubviews(titleLabel, plusImage, text1Label, text2Label, text3Label, button, slider);

            var guide = View.SafeAreaLayoutGuide;

            NSLayoutConstraint.ActivateConstraints(new[]
            {
                titleLabel.TopAnchor.ConstraintEqualTo(guide.TopAnchor, 16),
                titleLabel.LeadingAnchor.ConstraintEqualTo(guide.LeadingAnchor, 8),
                titleLabel.TrailingAnchor.ConstraintEqualTo(guide.TrailingAnchor, -8),

                plusImage.TopAnchor.ConstraintEqualTo(titleLabel.BottomAnchor, 16),
                plusImage.LeadingAnchor.ConstraintEqualTo(guide.LeadingAnchor, 8),
                plusImage.WidthAnchor.ConstraintEqualTo(40),
                plusImage.BottomAnchor.ConstraintEqualTo(slider.BottomAnchor),

                text1Label.LeadingAnchor.ConstraintEqualTo(plusImage.TrailingAnchor, 16),
                text2Label.LeadingAnchor.ConstraintEqualTo(plusImage.TrailingAnchor, 16),
                text3Label.LeadingAnchor.ConstraintEqualTo(plusImage.TrailingAnchor, 16),

                text1Label.TopAnchor.ConstraintEqualTo(plusImage.TopAnchor),
                text2Label.TopAnchor.ConstraintEqualTo(text1Label.BottomAnchor, 8),
                text3Label.TopAnchor.ConstraintEqualTo(text2Label.BottomAnchor, 8),

                button.LeadingAnchor.ConstraintGreaterThanOrEqualTo(text1Label.TrailingAnchor, 16),
                button.LeadingAnchor.ConstraintGreaterThanOrEqualTo(text2Label.TrailingAnchor, 16),
                button.LeadingAnchor.ConstraintGreaterThanOrEqualTo(text3Label.TrailingAnchor, 16),
                button.WidthAnchor.ConstraintGreaterThanOrEqualTo(60),

                button.TopAnchor.ConstraintEqualTo(text1Label.TopAnchor),
                button.BottomAnchor.ConstraintEqualTo(text3Label.BottomAnchor),

                slider.TopAnchor.ConstraintEqualTo(text3Label.BottomAnchor, 8),
                slider.LeadingAnchor.ConstraintEqualTo(text1Label.LeadingAnchor),
                slider.TrailingAnchor.ConstraintEqualTo(button.TrailingAnchor),
            });
        }
    }
}
