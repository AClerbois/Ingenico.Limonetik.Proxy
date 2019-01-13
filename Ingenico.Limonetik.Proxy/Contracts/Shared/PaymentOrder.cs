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

        /// <summary>
        /// If AddElements=OperationsSummary is added to the request URL, the PaymentOrder section of the response will include an OperationsSummary sub-section that contains information on the amounts associated with all operations conducted and any possible future operations:
        /// </summary>
        public OperationSummary OperationsSummary { get; set; }

        /// <summary>
        /// If AddElements=PaymentMethods is added to the request URL, the PaymentOrder section of the response will include a PaymentMethods sub-section that contains details of the payment methods used:
        /// </summary>
        public PaymentMethod[] PaymentMethods { get; set; }

        /// <summary>
        /// If AddElements=ScheduledOperations is added to the request URL, the ScheduledOperations section of the response will include a ScheduledOperation sub-section that contains details of the scheduled operations initially requested:
        /// </summary>
        public ScheduledOperation[] ScheduledOperations { get; set; }
    }
}