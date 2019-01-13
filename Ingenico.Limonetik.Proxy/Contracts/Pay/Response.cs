using Ingenico.Limonetik.Proxy.Contracts.Shared;

namespace Ingenico.Limonetik.Proxy.Contracts.Pay
{
    public class Response : BaseResponse
    {
        /// <summary>
        /// Operation identifier
        /// </summary>
        public int OperationId { get; set; }
    }
}
