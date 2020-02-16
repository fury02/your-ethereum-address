using System;
using System.Threading.Tasks;

using CryptocurrencyAdressGenerator.Model.Implementation;

namespace CryptocurrencyAdressGenerator.Infrastructure.Interface
{
    public interface IClient
    {
        Task Start(string substring, Action<KeyPairsEth> action);
        Task Stop();
        Task SaveClipboard(string key);
    }
}
