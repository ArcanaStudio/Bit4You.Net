using System;
using Net.Arcanastudio.Bit4You.Model.Exceptions;
using Net.Arcanastudio.Bit4You.Service;

namespace Net.Arcanastudio.Bit4You.Extensions
{
    internal static class MappingExtensions
    {
        public static Bit4YouException.ErrorInfo ToErrorInfo(this Bit4YouService.RequestError error)
        {
            if (error == null)
                throw new ArgumentNullException(nameof(error));

            var ei = new Bit4YouException.ErrorInfo
            {
                Message = error.Message, Reconnect = error.Reconnect, Status = error.Status
            };

            return ei;
        }
    }
}
