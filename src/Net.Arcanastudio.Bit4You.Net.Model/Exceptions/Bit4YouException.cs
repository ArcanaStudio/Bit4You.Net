using System;
using System.Net;

namespace Net.Arcanastudio.Bit4You.Model.Exceptions
{
    public class Bit4YouException : Exception
    {
        public HttpStatusCode Code { get; set; }
        public ErrorInfo Info { get; set; }

        public Bit4YouException(HttpStatusCode code, ErrorInfo errordata)
        {
            Code = code;
            Info = errordata ?? throw new ArgumentNullException(nameof(errordata));
        }
        public class ErrorInfo
        {
            public string Status { get; set; }
            public string Message { get; set; }
            public bool? Reconnect { get; set; }
        }
    }
}
