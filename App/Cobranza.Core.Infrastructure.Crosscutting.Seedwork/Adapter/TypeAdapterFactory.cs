namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter
{
    public static class TypeAdapterFactory
    {
        private static ITypeAdapterFactory currentTypeAdapterFactory;

        public static void SetCurrent(ITypeAdapterFactory adapterFactory)
        {
            currentTypeAdapterFactory = adapterFactory;
        }

        public static ITypeAdapter CreateAdapter()
        {
            return currentTypeAdapterFactory.Create();
        }
    }
}