using System;

namespace Ingenico.Limonetik.Proxy.Configuration
{
    internal struct RuntimeConfiguration
    {
        public Uri Url { get; set; }
        public string Login { get; set; }
        public string Key { get; set; }
    }
}