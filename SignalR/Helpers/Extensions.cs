using Microsoft.AspNetCore.SignalR;

namespace SignalR.Helpers
{
    public static class Extensions
    {
        public static dynamic Client(this IClientProxy proxy)
        {
            return new SignalRDispatcher(proxy);
        }
    }
}
