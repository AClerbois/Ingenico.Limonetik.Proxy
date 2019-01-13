namespace Ingenico.Limonetik.Proxy.IntegrationTests.Services
{
    public class LimonetikConfiguration : Configuration.ILimonetikConfiguration
    {
        public bool IsProduction => false;

        public string ApiProductionLogin => throw new System.NotImplementedException();

        public string ApiProductionKey => throw new System.NotImplementedException();

        public string ApiTestLogin => "ogone-fr";

        public string ApiTestKey => "dmZZTDRnYmpRdVprOkNERUQ3RjY1QTMxMDNDRUFFMzQ0RUMyQTI1NUYxREMy";
    }
}
