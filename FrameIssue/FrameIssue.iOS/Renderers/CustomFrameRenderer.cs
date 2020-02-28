using System;
using CoreGraphics;
using FrameIssue.Controls;
using FrameIssue.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace FrameIssue.iOS.Renderers
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public CustomFrameRenderer()
        {
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            Layer.ShadowRadius = 2.0f;
            Layer.ShadowOffset = new CGSize(2, 2);
            Layer.ShadowOpacity = 0.4f;
            Layer.ShadowPath = UIBezierPath.FromRoundedRect(Layer.Bounds, 15).CGPath;
            Layer.MasksToBounds = false;
            Layer.CornerRadius = 15;
            Layer.BorderColor = UIColor.FromRGB(211, 211, 211).CGColor;
            Layer.BackgroundColor = UIColor.White.CGColor;
            Layer.BorderWidth = 1;
        }
    }
}
