using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg;
using NUnit.Framework;

namespace Cobranza.Core.Domain.Tests.ProcesoCargaModule
{
    [TestFixture]
    public class MetaArchivoValidatorTests
    {
        [Test]
        public void MetaArchivoShouldBeValidForCreation()
        {
            IMetaArchivoValidator sut = new MetaArchivoValidator();

            var metaArchivo = new MetaArchivo();

            Assert.That(sut.IsValidForCreate(metaArchivo, null), Is.False);
        }

        [Test]
        public void MetaArchivoShouldNotBeValidForCreation()
        {
            IMetaArchivoValidator sut = new MetaArchivoValidator();

            var metaArchivo = new MetaArchivo();

            Assert.That(sut.IsValidForCreate(metaArchivo, null), Is.False);
        }
    }
}
