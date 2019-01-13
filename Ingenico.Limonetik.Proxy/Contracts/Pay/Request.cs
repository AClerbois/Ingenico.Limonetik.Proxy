using Ingenico.Limonetik.Proxy.Contracts.Shared;

namespace Ingenico.Limonetik.Proxy.Contracts.Pay
{
    public class Request
    {
        /// <summary>
        /// Limonetik payment order identifier
        /// </summary>
        /// <remarks>Corresponds to the PaymentOrderId parameter returned when the payment order was created.</remarks>
        public PaymentOrder PaymentOrder { get; set; }

        /// <summary>
        /// List of object related to the buyer payment information
        /// </summary>
        /// <remarks>
        /// Several information can be necessary. It's important to use unique names.
        /// </remarks>
        public CredentialModel[] Credentials { get; set; }
    }
}