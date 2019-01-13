namespace Ingenico.Limonetik.Proxy.Configuration
{
    public interface ILimonetikConfiguration
    {
        bool IsProduction { get; }
        string ApiProductionLogin { get; }
        string ApiProductionKey { get; }
        string ApiTestLogin { get; }
        string ApiTestKey { get; }
    }
}