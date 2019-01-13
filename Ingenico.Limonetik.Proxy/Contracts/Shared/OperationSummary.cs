using System;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class OperationSummary
    {
        /// <summary>
        /// The part of the authorized amount that is held as a guarantee (actually charged to the payment methods). This amount may decrease after a cancellation or charging operation. It corresponds to the debt owed to the user.
        /// Support services can therefore deduce whether an amount has actually been charged to a payment method; likewise, this parameter is set to zero after a full cancellation, indicating that there is no longer any debt to the user.
        /// </summary>
        public float HeldAmount { get; set; }

        /// <summary>
        /// Date after which the amount deducted as a guarantee (HeldAmount) will be released
        /// </summary>
        public DateTime HoldReleaseMaxDate { get; set; }

        /// <summary>
        /// Total amount authorized
        /// </summary>
        public float AuthorizedAmount { get; set; }

        /// <summary>
        /// Total amount charged
        /// </summary>
        public float ChargedAmount { get; set; }

        /// <summary>
        /// Amount currently being charged
        /// </summary>
        public float ChargingAmount { get; set; }

        /// <summary>
        /// Amount that can still be charged
        /// </summary>
        public float ChargeableAmount { get; set; }

        /// <summary>
        /// Date after which charges can no longer be guaranteed. Limonetik ensures that charges are guaranteed for at least 7 days, but the guarantee period can be longer.
        /// </summary>
        public DateTime EndOfChargeHonorPeriod { get; set; }

        /// <summary>
        /// Date after which charging operations are no longer possible:
        /// - Charges attempted between the EndOfChargeHonorPeriod and the EndOfChargePeriod may succeed or fail
        /// - After the EndOfChargePeriod, all charging attempts will fail
        /// </summary>
        public DateTime EndOfChargePeriod { get; set; }

        /// <summary>
        /// Total amount cancelled
        /// </summary>
        public float CancelledAmount { get; set; }

        /// <summary>
        /// Amount currently being cancelled
        /// </summary>
        public float CancellingAmount { get; set; }

        /// <summary>
        /// Amount that may still be cancelled
        /// </summary>
        public float CancellableAmount { get; set; }

        /// <summary>
        /// Date up to which cancellations are possible
        /// </summary>
        public DateTime EndOfCancelPeriod { get; set; }

        /// <summary>
        /// Total amount refunded
        /// </summary>
        public float RefundedAmount { get; set; }

        /// <summary>
        /// Amount currently being refunded
        /// </summary>
        public float RefundingAmount { get; set; }

        /// <summary>
        /// Amount that may still be refunded
        /// </summary>
        public float RefundableAmount { get; set; }
    }
}
