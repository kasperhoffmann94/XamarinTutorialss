using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(HPlusSports.Controls.NumberEntry),
    typeof(HPlusSports.Droid.Controls.NumberEntryRenderer))]
namespace HPlusSports.Droid.Controls
{
    public class NumberEntryRenderer : EntryRenderer
    {
        public NumberEntryRenderer(Context ctx) : base(ctx)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.InputType = Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberVariationNormal;
            } 
        }
    }
}
