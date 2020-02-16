using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CryptocurrencyAdressGenerator.View.UserControl
{
    public partial class ViewTextEntry : ContentView
    {
        // BindableProperty
        public static readonly BindableProperty SubstringTextPublicProperty = BindableProperty.Create(
                propertyName: nameof(SubstringTextPublic),
                returnType: typeof(string),
                declaringType: typeof(ViewTextEntry),
                defaultValue: default(string),
                propertyChanged: HandleTextPropertyChanged,
                defaultBindingMode: BindingMode.TwoWay);

        public string SubstringTextPublic
        {
            get => (string)GetValue(SubstringTextPublicProperty);
            set => SetValue(SubstringTextPublicProperty, value);
        }

        // Handler
        private static void HandleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ViewTextEntry)bindable;
            if (control != null)
            {
                control.EntrySubstringTextPublic.Text = (string)newValue;
            }
        }

        public ViewTextEntry()
        {
            InitializeComponent();
        }
    }
}