using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using Xamarin.Forms;

using Unity;

using CryptocurrencyAdressGenerator.MVVM.Helpers.HelperCommand;
using CryptocurrencyAdressGenerator.IoC;
using CryptocurrencyAdressGenerator.Model.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Interface;
using Xamarin.Essentials;

namespace CryptocurrencyAdressGenerator.ViewModel.Implementation
{
    class AboutViewModel : BaseViewModel
    {
        private readonly Uri uriGitHub;
        private readonly Uri uriEtherscan;
        public AboutViewModel()
        {
            uriGitHub = new Uri("https://github.com/fury02/Your-Ethereum-Address");
            uriEtherscan = new Uri("https://etherscan.io/address/0x7775397118C5DfBB7b7b40DBb711DD01371F08db");
        }

        public ICommand ClickCommandGitHub => new Command<string>(async (url) =>
        {
            await Xamarin.Essentials.Browser.OpenAsync(uriGitHub, BrowserLaunchMode.SystemPreferred);
        });

        public ICommand ClickCommandEtherscan => new Command<string>(async (url) =>
        {
            await Xamarin.Essentials.Browser.OpenAsync(uriEtherscan, BrowserLaunchMode.SystemPreferred);
        });
    }
}
