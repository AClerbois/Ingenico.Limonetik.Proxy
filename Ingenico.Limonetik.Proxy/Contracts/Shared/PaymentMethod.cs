namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class PaymentMethod
    {
        /// <summary>
        /// Payment method type: CreditCard, GiftCard, Discount, Wallet
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Payment method name: Visa, illicado, Cdgp, Paypal, etc.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Reference number: 4587 5496 xxxx xxxx
        /// </summary>
        public string Ref { get; set; }

        /// <summary>
        /// Company processing the payment: Payline, BanqueAccord, Cdgp, Paypal
        /// </summary>
        public string Processor { get; set; }

        /// <summary>
        /// Amount for authorisation operations currently being processed on the payment method server
        /// </summary>
        public float AuthorizedAmount { get; set; }

        /// <summary>
        /// Amount successfully authorized by Limonetik on the payment method server
        /// </summary>
        public float AuthorizingAmount { get; set; }

        /// <summary>
        /// Amount successfully charged by Limonetik to the payment method server
        /// </summary>
        public float DebitedAmount { get; set; }

        /// <summary>
        /// Amount successfully refunded by Limonetik to the payment method server
        /// </summary>
        public float RecreditedAmount { get; set; }

        /// <summary>
        /// Free text field provided by the payment method
        /// </summary>
        public string RawCustom { get; set; }
    }
}