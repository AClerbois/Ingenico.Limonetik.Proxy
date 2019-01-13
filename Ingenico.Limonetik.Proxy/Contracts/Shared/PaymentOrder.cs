namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class PaymentOrder
    {
        /// <summary>
        /// Your retailer identifier
        /// </summary>
        /// <remarks>Provided by Limonetik</remarks>
        public string MerchantId { get; set; }

        /// <summary>
        /// Payment method identifier
        /// </summary>
        /// <remarks>Provided by Limonetik</remarks>
        public string PaymentPageId { get; set; }

        /// <summary>
        /// Payment order amount
        /// </summary>
        /// <remarks>Use a decimal point and two decimal places, e.g. 100.00</remarks>
        public float Amount { get; set; }

        /// <summary>
        /// Payment order currency
        /// </summary>
        /// <remarks>Codified as specified in ISO 4217. Currently, Limonetik only handles payments in euros (EUR).</remarks>
        /// <example>EUR</example>
        public string Currency { get; set; }

        public MerchantUrls MerchantUrls { get; set; }

        public MerchantOrder MerchantOrder { get; set; }
    }
}