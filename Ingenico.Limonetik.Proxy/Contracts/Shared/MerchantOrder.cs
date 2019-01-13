using System.ComponentModel.DataAnnotations;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class MerchantOrder
    {
        /// <summary>
        /// Order identifier used by the retailer. This field is optional, but should be left blank only by retailers that do not handle this information.
        /// </summary>
        /// <remarks>type: String</remarks>
        /// <example>1257981</example>
        [MaxLength(20)]
        public string Id { get; set; }

        /// <summary>
        /// Full order amount, including tax and delivery costs
        /// </summary>
        /// <remarks>type: Amount</remarks>
        /// <example>70.00</example>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Tax amount
        /// </summary>
        /// <remarks>type: Amount</remarks>
        /// <example>13.72</example>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Order currency
        /// </summary>
        /// <remarks>type: Currency</remarks>
        /// <example>EUR</example>
        [MaxLength(3)]
        public string Currency { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        /// <remarks>type: String, max-length: 500</remarks>
        [MaxLength(500)]
        public string RawCustom1 { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        /// <remarks>type: String, max-length: 500</remarks>
        [MaxLength(500)]
        public string RawCustom2 { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        /// <remarks>type: String, max-length: 500</remarks>
        [MaxLength(500)]
        public string RawCustom3 { get; set; }

        /// <summary>
        /// Can be used to specify a value that will be indexed
        /// by Limonetik to optimize search queries
        /// </summary>
        /// <remarks>type: String, max-length: 20</remarks>
        [MaxLength(20)]
        public string SearchableCustom1 { get; set; }

        /// <summary>
        /// Can be used to specify a value that will be indexed
        /// by Limonetik to optimize search queries
        /// </summary>
        /// <remarks>type: String, max-length: 20</remarks>
        [MaxLength(20)]
        public string SearchableCustom2 { get; set; }

        /// <summary>
        /// Customer information
        /// </summary>
        /// <see cref="Customer"/>
        public Customer Customer { get; set; }

        /// <summary>
        /// Delivery address
        /// </summary>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Billing address
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Details of shopping cart content
        /// </summary>
        public CartItem[] CartItems { get; set; }
    }
}