using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(HPlusSports.Controls.NumberEntry),
    typeof(HPlusSports.iOS.Controls.NumberEntryRenderer))]
namespace HPlusSports.iOS.Controls
{
    public class NumberEntryRenderer : EntryRenderer
    {
        public NumberEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.KeyboardType = UIKit.UIKeyboardType.NumberPad;
            }
        }
    }
}
