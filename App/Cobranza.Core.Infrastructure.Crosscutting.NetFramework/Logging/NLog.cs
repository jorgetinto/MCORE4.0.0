using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging;
using NLog;
using System;
using System.Globalization;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Logging
{
    public sealed class NLog
        : ILogger
    {
        private readonly Logger source;

        public NLog()
        {
            // Create default source
            this.source = LogManager.GetLogger("Cobranza.Core");
        }

        public void Info(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                this.source.Info(messageToTrace);
            }
        }

        public void Warning(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                this.source.Warn(messageToTrace);
            }
        }

        public void Error(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                this.source.Error(messageToTrace);
            }
        }

        public void Error(string message, Exception exception, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();

                this.source.Error(
                                string.Format(
                                    CultureInfo.InvariantCulture,
                                    "{0} Exception:{1}",
                                    messageToTrace,
                                    exceptionData));
            }
        }

        public void Debug(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                this.source.Debug(messageToTrace);
            }
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();

                this.source.Debug(
                                string.Format(
                                    CultureInfo.InvariantCulture,
                                    "{0} Exception:{1}",
                                    messageToTrace,
                                    exceptionData));
            }
        }

        public void Debug(object item)
        {
            if (item != null)
            {
                this.source.Debug(item.ToString());
            }
        }

        public void Fatal(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                this.source.Fatal(messageToTrace);
            }
        }

        public void Fatal(string message, Exception exception, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();

                this.source.Fatal(
                                string.Format(
                                    CultureInfo.InvariantCulture,
                                    "{0} Exception:{1}",
                                    messageToTrace,
                                    exceptionData));
            }
        }
    }
}