using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.ExportRenderer(typeof(HPlusSports.Controls.NumberEntry), typeof(HPlusSports.iOS.Controls.NumberEntryRendere))]
namespace HPlusSports.iOS.Controls
{
    public class NumberEntryRendere : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.KeyboardType = UIKit.UIKeyboardType.NumberPad;
            }

        }
    }

}