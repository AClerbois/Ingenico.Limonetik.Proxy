using System.ComponentModel.DataAnnotations;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    /// <summary>
    /// Delivery address and billing address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Company
        /// </summary>
        /// <example>Limonetik</example>
        [MaxLength(50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Mr, Mrs, Dr, etc.
        /// </summary>
        /// <example>Mr</example>
        [MaxLength(20)]
        public string Title { get; set; }

        /// <summary>
        /// Customer's first name
        /// </summary>
        /// <example>John</example>
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer's last name
        /// </summary>
        /// <example>Doe</example>
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        /// <example>123, Main Street</example>
        [MaxLength(100)]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <example></example>
        [MaxLength(100)]
        public string Address2 { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        /// <example>PO17 6DZ</example>
        [MaxLength(20)]
        public string ZipCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <example>Southwick</example>
        [MaxLength(50)]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <example>United Kingdom</example>
        [MaxLength(50)]
        public string Country { get; set; }

        /// <summary>
        /// Customer's home phone number
        /// </summary>
        /// <example>+44012345678</example>
        [MaxLength(50)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Customer's mobile phone number
        /// </summary>
        /// <example>+44012345678</example>
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        /// <example></example>
        [MaxLength(500)]
        public string RawCustom { get; set; }
    }
}
