using Unity;

using CLGeneratorKeyPairs.Ethereum.Interface;
using CLGeneratorKeyPairs.Ethereum.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Interface;
using CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Implementation;
using CryptocurrencyAdressGenerator.Infrastructure.Interface;

namespace CryptocurrencyAdressGenerator.IoC
{
    public class DIRegisterTypes
    {
        public  UnityContainer unity;
        public DIRegisterTypes()
        {
            unity = new UnityContainer();

            unity.RegisterType<IGenerateAddressToEthereum, GenerateAddressToEthereum>();
            unity.RegisterType<IRandomAddresses, RandomAddresses>();
 
            unity.RegisterSingleton<IClient, Client>(); 
        }
    }
}
