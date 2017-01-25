using System.Configuration;
using System.Globalization;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Configuration
{
    public static class AppSettingsHelper
    {
        public static int BulkInsertBatchSize
        {
            get
            {
                return int
                    .Parse(ConfigurationManager.AppSettings["BulkInsertBatchSize"], CultureInfo.InvariantCulture);
            }
        }

        public static int BulkInsertBulkCopyTimeout
        {
            get
            {
                return int
                    .Parse(ConfigurationManager.AppSettings["BulkInsertBulkCopyTimeout"], CultureInfo.InvariantCulture);
            }
        }
    }
}
