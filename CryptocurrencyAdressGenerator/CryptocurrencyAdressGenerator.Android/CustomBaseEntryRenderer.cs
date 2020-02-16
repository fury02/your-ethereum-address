using Android.Content;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CryptocurrencyAdressGenerator.Renderers;
using CryptocurrencyAdressGenerator.Droid;

[assembly: ExportRenderer(typeof(CustomBaseEntry), typeof(CustomBaseEntryRenderer))]
namespace CryptocurrencyAdressGenerator.Droid
{
    class CustomBaseEntryRenderer : EntryRenderer
    {
        public CustomBaseEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
            }
        }
    }
}