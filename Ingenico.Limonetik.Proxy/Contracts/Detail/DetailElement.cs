using System;

namespace Ingenico.Limonetik.Proxy.Contracts.Detail
{
    [Flags]
    public enum DetailElement
    {
        MerchantUrls = 1,
        OperationsSummary = 2,
        PaymentMethods = 4,
        MerchantOrder = 8,
        ScheduledOperations = 16
    }
}