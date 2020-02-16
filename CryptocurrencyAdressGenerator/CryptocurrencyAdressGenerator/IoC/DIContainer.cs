namespace CryptocurrencyAdressGenerator.IoC
{
    public static class DIContainer
    {
        public static DIRegisterTypes container;

        public static void Init()
        {
            container = new DIRegisterTypes();
        }
    }
}
