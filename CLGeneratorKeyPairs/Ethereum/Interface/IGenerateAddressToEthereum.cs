using CLGeneratorKeyPairs.Ethereum.Model;

namespace CLGeneratorKeyPairs.Ethereum.Interface
{
    public interface IGenerateAddressToEthereum
    {
        KeyPairs RandomKeyPairs();
    }
}
