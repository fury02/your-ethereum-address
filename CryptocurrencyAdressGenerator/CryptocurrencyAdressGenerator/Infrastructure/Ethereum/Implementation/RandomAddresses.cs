using System;
using System.Threading.Tasks;
using System.Threading;

using CLGeneratorKeyPairs.Ethereum.Interface;
using CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Interface;
using CryptocurrencyAdressGenerator.Model.Implementation;

namespace CryptocurrencyAdressGenerator.Infrastructure.Ethereum.Implementation
{
    public class RandomAddresses : IRandomAddresses
    {
        private IGenerateAddressToEthereum generate;

        public RandomAddresses(IGenerateAddressToEthereum generate)
        {
            this.generate = generate;
        }

        public async Task Search(string StringPattern, Action<KeyPairsEth> action, CancellationToken cancellationToken)
        {
            string s = "0x" + StringPattern;
            int count = s.Length;

            await Task.Run(delegate
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }

                    KeyPairsEth result = generate.RandomKeyPairs();
                    string publiceKey = result.PublicKey;
                    if (publiceKey.Substring(0, count) == s)
                    {
                        KeyPairsEth pairs = result;
                        action.Invoke(pairs);
                        break;
                    }
                };
            });
        }
    }
}


////Для теста на возможные совпадения ( не корреетность работы библиотеки)
//public async Task Search(string StringPattern, Action<KeyPairsEth> action, CancellationToken cancellationToken)
//{
//    string s = "0x" + StringPattern;
//    int count = s.Length;

//    List<string> list = new List<string>();
//    int i = 0;

//    await Task.Run(delegate
//    {
//        while (true)
//        {
//            if (cancellationToken.IsCancellationRequested)
//            {
//                break;
//            }

//            KeyPairsEth result = generate.RandomKeyPairs();
//            string publiceKey = result.PublicKey;

//            if (publiceKey.Substring(0, count) == s)
//            {
//                KeyPairsEth pairs = result;

//                if (list.Contains(pairs.PublicKey))
//                {
//                    action.Invoke(pairs);
//                    break;
//                }

//                list.Add(pairs.PublicKey);
//                i++;

//                if (i == 101)
//                {
//                    pairs.PrivateKey = "0";
//                    pairs.PublicKey = "0";
//                    action.Invoke(pairs);
//                    break;
//                }

//                //action.Invoke(pairs);
//                //break;
//            }
//        };
//    });
//}
