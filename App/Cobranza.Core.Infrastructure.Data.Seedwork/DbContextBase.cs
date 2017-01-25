using System.Data.Entity;

namespace Cobranza.Core.Infrastructure.Data.Seedwork
{
    public class DbContextBase<TContext>
    : DbContext where TContext : DbContext
    {
        static DbContextBase()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected DbContextBase()
            : base("name=CoreContext")
        {
        }
    }
}
