using Microsoft.AspNetCore.SignalR;
using System.Dynamic;

namespace SignalR.Helpers
{
    public class SignalRDispatcher : DynamicObject
    {
        private readonly IClientProxy _proxy;

        public SignalRDispatcher(IClientProxy proxy)
        {
            _proxy = proxy;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
        {
            args ??= Array.Empty<object?>();

            result = _proxy.SendCoreAsync(binder.Name, args);

            return true;
        }
    }
}
