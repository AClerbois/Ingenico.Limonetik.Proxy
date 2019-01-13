using Ingenico.Limonetik.Proxy.Contracts.Shared;

namespace Ingenico.Limonetik.Proxy.Contracts.CreatePayment
{
    public class Response : BaseResponse
    {
        /// <summary>
        /// Unique payment order identifier on the Limonetik platform
        /// </summary>
        /// <remarks>
        /// Make note of this identifier for performing other operations on the payment order.
        /// </remarks>
        public long PaymentOrderId { get; set; }

        /// <summary>
        /// URL of the payment page
        /// </summary>
        /// <remarks>
        /// Redirect the user to this page (HTTP 302) to make his or her payment.
        /// </remarks>
        public string PaymentPageUrl { get; set; }
    }
}