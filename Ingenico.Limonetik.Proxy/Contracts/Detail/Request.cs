namespace Ingenico.Limonetik.Proxy.Contracts.Detail
{
    public class Request
    {
        /// <summary>
        /// Limonetik payment order identifier. Corresponds to the PaymentOrderId parameter returned when the payment order was created
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identifiers for any additional fields required.
        /// </summary>
        public DetailElement? AddElements { get; set; }
    }
}