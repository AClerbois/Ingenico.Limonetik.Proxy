using Ingenico.Limonetik.Proxy.Contracts.CreatePayment;
using Ingenico.Limonetik.Proxy.Contracts.Shared;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Ingenico.Limonetik.Proxy.IntegrationTests.Services
{
    public class LimonetikCallerServiceTests
    {

        private readonly ITestOutputHelper output;

        public LimonetikCallerServiceTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async Task CreateAPayment()
        {
            var httpClient = new HttpClient();
            var client = new Proxy.Services.LimonetikCallerService(httpClient, new LimonetikConfiguration());
            var request = new Request
            {
                PaymentOrder = new PaymentOrder
                {
                    MerchantId = "ogone-fr",
                    PaymentPageId = "sofinco3xcb",
                    Amount = 15,
                    Currency = "EUR",
                    MerchantUrls = new MerchantUrls
                    {
                        AbortedUrl = "http://www.abortedurl.com/",
                        ErrorUrl = "http://www.errorurl.com/",
                        ReturnUrl = "http://www.returnurl.com/",
                        ServerNotificationUrl = "http://www.servernotificationurl.com/"
                    },
                    MerchantOrder = new MerchantOrder
                    {
                        Customer = new Customer
                        {
                            Email = "adrien.clerbois@outlook.com"
                        },
                        TotalAmount = 15,
                        Id = "12365",
                        Currency = "EUR"                        

                    }
                }
            };
            var response = await client.CreatePaymentAsync(request);

            if (response.ReturnCode > 1000)
            {
                output.WriteLine(response.ReturnMessage);
            }
            Assert.Equal(1000, response.ReturnCode);
        }

        [Fact]
        public async Task GetPaymentDataTransaction()
        {
            var httpClient = new HttpClient();
            var client = new Proxy.Services.LimonetikCallerService(
                httpClient, new LimonetikConfiguration());
            var detailsRequest = new Contracts.Detail.Request {
                Id = "274060854832",
                AddElements = Contracts.Detail.DetailElement.OperationsSummary | Contracts.Detail.DetailElement.MerchantOrder | Contracts.Detail.DetailElement.MerchantUrls | Contracts.Detail.DetailElement.PaymentMethods | Contracts.Detail.DetailElement.PaymentMethods
            };
            var result = await client.DetailAsync(detailsRequest);

        }
    }
}