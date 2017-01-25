using System;

namespace Cobranza.Core.Domain.Seedwork
{
    [Serializable]
    public class PropertyNotFoundException : Exception
    {
        private readonly string _propertyName;

        public PropertyNotFoundException()
        {
        }

        public PropertyNotFoundException(string propertyName)
        {
            this._propertyName = propertyName;
        }

        public PropertyNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public PropertyNotFoundException(string message, string propertyName)
            : base(message)
        {
            this._propertyName = propertyName;
        }

        protected PropertyNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        public string PropertyName
        {
            get
            {
                return this._propertyName;
            }
        }
    }
}
