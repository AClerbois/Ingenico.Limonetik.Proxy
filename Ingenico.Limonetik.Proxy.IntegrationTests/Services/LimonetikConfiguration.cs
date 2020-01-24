namespace Ingenico.Limonetik.Proxy.IntegrationTests.Services
{
    public class LimonetikConfiguration : Configuration.ILimonetikConfiguration
    {
        public bool IsProduction { get; set; } = false;

        public string ApiProductionLogin => "norauto-pt";

        public string ApiProductionKey => "VlpHZHlOQVhFMVlnOjcyMEMxMzgxRDUzMEQzNUU4QUVFOTk4NTRBMkE5MUZG";

        public string ApiTestLogin => "ogone-fr";

        public string ApiTestKey => "dmZZTDRnYmpRdVprOkNERUQ3RjY1QTMxMDNDRUFFMzQ0RUMyQTI1NUYxREMy";
    }
}
