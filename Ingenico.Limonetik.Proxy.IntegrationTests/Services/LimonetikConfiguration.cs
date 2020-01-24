namespace Ingenico.Limonetik.Proxy.IntegrationTests.Services
{
    public class LimonetikConfiguration : Configuration.ILimonetikConfiguration
    {
        public bool IsProduction { get; set; } = false;

        public string ApiProductionLogin => "";

        public string ApiProductionKey => "";

        public string ApiTestLogin => "";

        public string ApiTestKey => "";
    }
}
