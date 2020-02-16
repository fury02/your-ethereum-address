using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Unity;
using Unity.ServiceLocation;
using CommonServiceLocator;

using CLGeneratorKeyPairs.Ethereum;
using CLGeneratorKeyPairs.Ethereum.Model;
using CLGeneratorKeyPairs.Ethereum.Interface;
using CryptocurrencyAdressGenerator.IoC;

using CryptocurrencyAdressGenerator.View;

using CryptocurrencyAdressGenerator.ViewModel.Implementation;


namespace CryptocurrencyAdressGenerator
{
    public partial class App : Application
    {
        public App()
        {
            DIContainer.Init();

            InitializeComponent();

            MainPage = new StartPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
