namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class MerchantUrls
    {
        /// <summary>
        /// URL to which Limonetik should redirect users if the authorisation request is confirmed.
        /// </summary>
        /// <remarks>If you have not yet received server-to-server notification (or if you don't use it), you must check the status of the payment order via the PaymentOrder/Detail web service (WS) before confirming the order. This is for security reasons and because the order status may be Authorized or Authorizing, accordingly.</remarks>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// URL to which Limonetik should redirect users if they cancel their payment.
        /// </summary>
        /// <remarks>We recommend using the payment method selection page to allow users to finalize their order using a different payment method.</remarks>
        public string AbortedUrl { get; set; }

        /// <summary>
        /// URL to which Limonetik should redirect users if an error occurs in the payment flow
        /// </summary>
        /// <remarks>We recommend using the payment method selection page to allow users to finalize their order using a different payment method.</remarks>
        public string ErrorUrl { get; set; }

        /// <summary>
        /// ServerNotificationUrl subscribers will receive automatic notification of some of these changes in status. For further information, see the Server-to-server notifications section. <seealso cref="https://docs.limonetik.com/v1.0/reference#server-to-server-notifications"/>
        /// </summary>
        public string ServerNotificationUrl { get; set; }
    }

}
