using System;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Essentials;

using CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Interface;
using CryptocurrencyAdressGenerator.Model.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Interface;

namespace CryptocurrencyAdressGenerator.Infrastructure.Implementation
{
    public class Client : IClient
    {
        private IRandomAddresses randomAddresses;
        private CancellationTokenSource cancellationTokenSource;

        public Client(IRandomAddresses randomAddresses)
        {
            this.randomAddresses = randomAddresses;
        }

        public async Task Start(string substring, Action<KeyPairsEth> action)
        {
            this.cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            await randomAddresses.Search(substring, action, token);
        }

        public async Task Stop()
        {
            await Task.Run(delegate { cancellationTokenSource.Cancel(); });
        }

        public async Task SaveClipboard(string key)
        {
            await Clipboard.SetTextAsync(key);
        }
    }
}
