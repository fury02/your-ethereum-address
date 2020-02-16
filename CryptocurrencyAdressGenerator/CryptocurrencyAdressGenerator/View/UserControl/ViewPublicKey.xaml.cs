using Xamarin.Forms;

namespace CryptocurrencyAdressGenerator.View.UserControl
{
    public partial class ViewPublicKey : ContentView
    {
     
        // BindableProperty
        public static readonly BindableProperty RandomKeyPublicProperty = BindableProperty.Create(
                propertyName: nameof(RandomKeyPublic),
                returnType: typeof(string),
                declaringType: typeof(ViewPublicKey),
                defaultValue: default(string),
                propertyChanged: HandleTextPropertyChanged,
                defaultBindingMode: BindingMode.TwoWay);

        public string RandomKeyPublic
        {
            get => (string)GetValue(RandomKeyPublicProperty);
            set => SetValue(RandomKeyPublicProperty, value);
        }

        // Handler
        private static void HandleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ViewPublicKey)bindable;
            if (control != null)
            {
                control.LabelPublicKeyPublic.Text = (string)newValue;
            }
        }
        public ViewPublicKey()
        {
            InitializeComponent();
        }
    }
}