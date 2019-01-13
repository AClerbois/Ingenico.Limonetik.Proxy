using System;

namespace Ingenico.Limonetik.Proxy.Configuration
{
    internal class ConfigurationFactory
    {
        private const string PRODUCTION_URL = "https://api.limonetik.com/Rest/V40/PaymentOrder/";
        private const string TEST_URL = "https://api.limonetikqualif.com/Rest/V40/PaymentOrder/";

        internal static RuntimeConfiguration Build(ILimonetikConfiguration configuration)
        {
            return configuration.IsProduction
            ? BuildProductionConfiguration(configuration)
            : BuildTestConfiguration(configuration);
        }

        private static RuntimeConfiguration BuildProductionConfiguration(ILimonetikConfiguration configuration)
        {
            return new RuntimeConfiguration
            {
                Url = new Uri(PRODUCTION_URL),
                Login = configuration.ApiProductionLogin,
                Key = configuration.ApiProductionKey
            };
        }

        private static RuntimeConfiguration BuildTestConfiguration(ILimonetikConfiguration configuration)
        {
            return new RuntimeConfiguration
            {
                Url = new Uri(TEST_URL),
                Login = configuration.ApiTestLogin,
                Key = configuration.ApiTestKey
            };
        }
    }
}