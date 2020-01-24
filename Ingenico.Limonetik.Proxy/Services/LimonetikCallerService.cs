using Ingenico.Limonetik.Proxy.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ingenico.Limonetik.Proxy.Services
{
    public partial class LimonetikCallerService
    {
        private readonly string CREATE_PAYMENT_URL = "Create";
        private readonly string DETAIL_URL = "Detail?Id={0}&AddElements={1}";
        private readonly string CHARGE_URL = "Charge";
        private readonly string CANCEL_URL = "Cancel";
        private readonly string REFUND_URL = "Refund";
        private readonly string PAY_URL = "Pay";

        public HttpClient Client { get; }

        public LimonetikCallerService(HttpClient client, ILimonetikConfiguration configuration)
        {
            var runtimeConfiguration = ConfigurationFactory.Build(configuration);
            client.BaseAddress = runtimeConfiguration.Url;
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var byteArray = Encoding.ASCII.GetBytes($"{runtimeConfiguration.Login}{runtimeConfiguration.Key}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            Client = client;
        }

        public async Task<Contracts.CreatePayment.Response> CreatePaymentAsync(Contracts.CreatePayment.Request request)
        {
            return await PostRequest<Contracts.CreatePayment.Request, Contracts.CreatePayment.Response>(request, CREATE_PAYMENT_URL);
        }

        public async Task<Contracts.Detail.Response> DetailAsync(Contracts.Detail.Request request)
        {
            string addElements = request.AddElements.HasValue
                ? ((Contracts.Detail.DetailElement)request.AddElements).ToString().Replace(" ", "")
                : string.Empty;

            return await GetRequest<Contracts.Detail.Response>(string.Format(DETAIL_URL, request.Id, addElements));
        }

        public async Task<Contracts.Charge.Response> ChargeAsync(Contracts.Charge.Request request)
        {
            return await PostRequest<Contracts.Charge.Request, Contracts.Charge.Response>(request, CHARGE_URL);
        }

        public async Task<Contracts.Pay.Response> PayAsync(Contracts.Pay.Request request)
        {
            return await PostRequest<Contracts.Pay.Request, Contracts.Pay.Response>(request, PAY_URL);
        }

        public async Task<Contracts.Refund.Response> RefundAsync(Contracts.Refund.Request request)
        {
            return await PostRequest<Contracts.Refund.Request, Contracts.Refund.Response>(request, REFUND_URL);
        }

        public async Task<Contracts.Cancel.Response> CancelAsync(Contracts.Cancel.Request request)
        {
            return await PostRequest<Contracts.Cancel.Request, Contracts.Cancel.Response>(request, CANCEL_URL);
        }

        private async Task<U> PostRequest<T, U>(T request, string url)
        {
            var requestContent = CreateRequest(request);
            var response = await Client.PostAsync(url, requestContent);
            return JsonConvert.DeserializeObject<U>(await response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetRequest<T>(string url)
        {
            var response = await Client.GetAsync(url);
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }

        private string Serialize(object objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
        }

        private StringContent CreateRequest(object request)
        {
            var content = Serialize(request);
            return new StringContent(content, Encoding.UTF8, "application/json");
        }
    }
}