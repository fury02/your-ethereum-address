namespace CryptocurrencyAdressGenerator.Model.Implementation
{
    public class KeyPairsEth
    {
     
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }

        public static implicit operator KeyPairsEth(CLGeneratorKeyPairs.Ethereum.Model.KeyPairs v) => 
            new KeyPairsEth() { PrivateKey= v.PrivateKey, PublicKey=v.PubliceKey};
        
    }
}
