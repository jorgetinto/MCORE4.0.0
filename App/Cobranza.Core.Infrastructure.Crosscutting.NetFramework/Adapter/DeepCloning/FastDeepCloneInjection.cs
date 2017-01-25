using FastMember;
using System;
using System.ComponentModel;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning
{
    public class FastDeepCloneInjection : DeepCloneInjection
    {
        protected override void SetValue(PropertyDescriptor prop, object component, object value)
        {
            if (prop == null)
            {
                throw new ArgumentNullException("prop");
            }

            if (component == null)
            {
                throw new ArgumentNullException("component");
            }

            var a = TypeAccessor.Create(component.GetType());

            a[component, prop.Name] = value;
        }

        protected override object GetValue(PropertyDescriptor prop, object component)
        {
            if (prop == null)
            {
                throw new ArgumentNullException("prop");
            }

            if (component == null)
            {
                throw new ArgumentNullException("component");
            }

            var a = TypeAccessor.Create(component.GetType(), true);

            return a[component, prop.Name];
        }
    }
}