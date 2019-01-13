using System;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class ResponsePaymentOrder : PaymentOrder
    {
        public string Status { get; set; }

        public DateTime CreateDate { get; set; }

        public string PaymentPageUrl { get; set; }
    }
}
