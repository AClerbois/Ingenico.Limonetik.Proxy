using System.ComponentModel.DataAnnotations;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    /// <summary>
    /// Information concerning the user
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Company
        /// </summary>
        /// <remarks>type: String</remarks>
        /// <example>Limonetik</example>
        [MaxLength(50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Mr, Mrs, Dr, etc.
        /// </summary>
        /// <remarks>type: String</remarks>
        /// <example>Mr</example>
        [MaxLength(20)]
        public string Title { get; set; }

        /// <summary>
        /// Customer type
        /// Accepted values: Professional / Individual
        /// </summary>
        /// <remarks>type: String</remarks>
        /// <example>Professional</example>
        [MaxLength(20)]
        [RegularExpression("Professional|Individual")]
        public string Type { get; set; }

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
        /// Customer's email address
        /// </summary>
        /// <example>john.doe@gmail.com</example>
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Customer's home phone number
        /// </summary>
        /// <example>+442012345678</example>
        [MaxLength(50)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Customer's mobile phone number
        /// </summary>
        /// <example>+442012345678</example>
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Free text field
        /// </summary>
        [MaxLength(500)]
        public string RawCustom { get; set; }

        /// <summary>
        /// Language and country, codified according to ISO 639 and ISO 3166
        /// </summary>
        /// <example>en-GB</example>
        public string Culture { get; set; }
    }

}
