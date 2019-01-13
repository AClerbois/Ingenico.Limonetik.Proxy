namespace Ingenico.Limonetik.Proxy.Contracts.Charge
{
    public class Request
    {
        /// <summary>
        /// Limonetik payment order identifier
        /// </summary>
        /// <remarks>Corresponds to the PaymentOrderId parameter returned when the payment order was created.</remarks>
        public string PaymentOrderId { get; set; }

        /// <summary>
        /// Amount to be charged
        /// </summary>
        /// <remarks>
        /// This amount must be less than or equal to the total order amount (minus any amounts that may already have been charged or cancelled).
        /// Use a decimal point and two decimal places, e.g. 70.00
        /// </remarks>
        /// <example>
        /// 70.00
        /// </example>
        public string ChargeAmount { get; set; }

        /// <summary>
        /// Payment order currency
        /// </summary>
        /// <remarks>
        /// Codified as specified in ISO 4217. At present, Limonetik only handles payments in euros (EUR).
        /// </remarks>
        /// <example>EUR</example>
        public string Currency { get; set; }
    }
}
