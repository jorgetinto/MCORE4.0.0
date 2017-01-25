namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter
{
    public interface ITypeAdapter
    {
        TTarget InjectFrom<TSource, TTarget>(TSource source, TTarget target)
            where TTarget : class
            where TSource : class;

        TTarget InjectFrom<TTarget>(object source, TTarget target)
            where TTarget : class;

        TTarget Adapt<TSource, TTarget>(TSource source)
            where TTarget : class, new()
            where TSource : class;

        TTarget Adapt<TTarget>(object source)
            where TTarget : class, new();

        ITypeAdapter WithFlattening();

        ITypeAdapter WithUnflattening();
    }
}