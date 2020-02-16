using Nethereum.Signer;
using Nethereum.Hex.HexConvertors.Extensions;

using CLGeneratorKeyPairs.Ethereum.Model;
using CLGeneratorKeyPairs.Ethereum.Interface;

namespace CLGeneratorKeyPairs.Ethereum.Implementation
{
    public class GenerateAddressToEthereum : IGenerateAddressToEthereum
    {
        private KeyPairs keyPairs;

        public GenerateAddressToEthereum()
        {
            keyPairs = new KeyPairs();
        }

        public KeyPairs RandomKeyPairs()
        {
            var ecKey = EthECKey.GenerateKey();
            var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
            var account = new Nethereum.Web3.Accounts.Account(privateKey);

            keyPairs.PubliceKey = account.Address;
            keyPairs.PrivateKey = account.PrivateKey;

            return keyPairs;
        }
    }
}
