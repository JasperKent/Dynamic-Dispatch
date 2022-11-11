using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class PropertyBag : DynamicObject
    {
        private readonly Dictionary<string, object?> _values = new Dictionary<string, object?>();

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            _values[binder.Name] = value;

            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            if(_values.ContainsKey(binder.Name))
            {
                result = _values[binder.Name];

                return true;
            }
            else
            {
                result = null;

                return false;
            }
        }
    }
}
