using System;
using System.Threading.Tasks;
using System.Threading;

using CryptocurrencyAdressGenerator.Model.Implementation;

namespace CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Interface
{
    public interface IRandomAddresses
    {
        Task Search(string StringPattern, Action<KeyPairsEth> action, CancellationToken cancellationToken);
    }
}
