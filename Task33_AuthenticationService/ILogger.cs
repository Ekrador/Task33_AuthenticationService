using System;

namespace Task33_AuthenticationService
{
    public interface ILogger
    {
        void WriteEvent(string eventMessage);
        void WriteError(string errorMesage);
    }
}
