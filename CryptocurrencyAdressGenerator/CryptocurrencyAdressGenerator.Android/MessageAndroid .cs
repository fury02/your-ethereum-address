using Android.App;
using Android.Widget;

using CryptocurrencyAdressGenerator.Infrastructure.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(CryptocurrencyAdressGenerator.Droid.MessageAndroid))]
namespace CryptocurrencyAdressGenerator.Droid
{
    public class MessageAndroid : IMessageAndroid
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}