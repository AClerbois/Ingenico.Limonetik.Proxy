namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class CredentialModel
    {
        /// <summary>
        /// Name of the payment information
        /// </summary>
        /// <remarks>
        /// Defined by Limonetik depending the payment method
        /// </remarks>
        public string Name{ get; set; }

        /// <summary>
        /// Value of the payment information
        /// </summary>
        public string Credential { get; set; }

    }
}
