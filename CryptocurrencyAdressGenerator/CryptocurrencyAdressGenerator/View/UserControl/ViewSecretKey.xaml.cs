using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CryptocurrencyAdressGenerator.View.UserControl
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSecretKey : ContentView
    {
        // BindableProperty
        public static readonly BindableProperty RandomKeySecretProperty = BindableProperty.Create(
                propertyName: nameof(RandomKeySecret),
                returnType: typeof(string),
                declaringType: typeof(ViewSecretKey),
                defaultValue: default(string),
                propertyChanged: HandleTextPropertyChanged,
                defaultBindingMode: BindingMode.TwoWay);

        public string RandomKeySecret
        {
            get => (string)GetValue(RandomKeySecretProperty);
            set => SetValue(RandomKeySecretProperty, value);          
        }

        // Handler
        private static void HandleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ViewSecretKey)bindable;
            if (control != null)
            {
                control.LabelSecretKeyPublic.Text = (string)newValue;
            }
        }
        public ViewSecretKey()
        {
            InitializeComponent();
        }
    }
}