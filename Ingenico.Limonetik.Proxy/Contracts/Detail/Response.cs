using Ingenico.Limonetik.Proxy.Contracts.Shared;

namespace Ingenico.Limonetik.Proxy.Contracts.Detail
{
    public class Response : BaseResponse
    {
        /// <summary>
        /// General transaction information
        /// </summary>
        /// <remarks>
        /// The Status field indicates the current transaction status (see the Status descriptions table). You should already have information about the other fields.
        /// </remarks>
        public ResponsePaymentOrder PaymentOrder { get; set; }
    }
}