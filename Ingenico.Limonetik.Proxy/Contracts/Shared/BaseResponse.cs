namespace Ingenico.Limonetik.Proxy.Contracts.Shared
{
    public abstract class BaseResponse
    {
        /// <summary>
        /// A numerical code that indicates the result of the operation
        /// </summary>
        public int ReturnCode { get; set; }

        /// <summary>
        /// A human-readable message describing the status of the response.
        /// </summary>
        public string ReturnMessage { get; set; }

        /// <summary>
        /// Each web service call is given a unique identifier that may be used for troubleshooting purposes. If a problem occurs with a call, you can send its RequestId to Limonetik for analysis.
        /// </summary>
        public string RequestId { get; set; }

    }
}