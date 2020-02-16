using System.Windows.Input;
using Xamarin.Forms;

using Unity;

using CryptocurrencyAdressGenerator.MVVM.Helpers.HelperCommand;
using CryptocurrencyAdressGenerator.IoC;
using CryptocurrencyAdressGenerator.Model.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Interface;

namespace CryptocurrencyAdressGenerator.ViewModel.Implementation
{
    public class MainViewModel : BaseViewModel
    {
        #region Interfaces
        private IClient client;
        #endregion

        #region Command
        public ICommand CommandStart { get; }
        public ICommand CommandStop { get; }
        public ICommand CommandSaveClipboard { get; }
        #endregion

        #region Property
        #region private field static 
        private static string stringPattern;
        private static string rndKeyPublic;
        private static string rndkeyPrivate;
        private static bool isPlayIndicator;
        #endregion

        public bool IsPlayIndicator
        {
            get => isPlayIndicator;
            set => SetProperty(ref isPlayIndicator, value);
        }

        public string StringPattern
        {
            get => stringPattern;
            set => SetProperty(ref stringPattern, value);
        }
          
        public string RndKeyPublic
        {
            get => rndKeyPublic; 
            set => SetProperty(ref rndKeyPublic, value); 
        }
   
        public string RndKeyPrivate
        {
            get =>  rndkeyPrivate;
            set => SetProperty(ref rndkeyPrivate, value);
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {        
            this.client = DIContainer.container.unity.Resolve<IClient>();

            CommandStart = new ButtonCommand(delegate { this.IsPlayIndicator = true; client.Start(this.StringPattern, HandlerResult); });

            CommandStop = new ButtonCommand(delegate { this.IsPlayIndicator = false; client.Stop(); });

            CommandSaveClipboard = new ButtonCommand
                (delegate 
                {                                      
                    client.SaveClipboard(this.RndKeyPrivate);
                    DependencyService.Get<IMessageAndroid>().ShortAlert("Secret key was copied");
                });
        }
        #endregion

        #region Actions
        private void HandlerResult(KeyPairsEth  keys)
        {           
            this.IsPlayIndicator = false;
            this.RndKeyPrivate = keys.PrivateKey;
            this.RndKeyPublic = keys.PublicKey;
        }
        #endregion
    }
}