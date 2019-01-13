using System;

namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public class ScheduledOperation
    {

        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Delay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ScheduledDate { get; set; }
    }
}