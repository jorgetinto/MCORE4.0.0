using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg;
using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.ValidationSpecifications;
using NUnit.Framework;
using System.Collections.Generic;

namespace Cobranza.Core.Domain.Tests.ProcesoCargaModule
{
    [TestFixture]
    public class MetaArchivoValidationSpecificationsTests
    {

        [Test]
        public void MetaArchivoShouldHaveFieldsConfigurated()
        {
            var specToTest = new HasFieldsConfiguratedSpecification();

            var metaArchivo = new MetaArchivo();

            Assert.IsFalse(specToTest
                               .IsSatisfiedBy(metaArchivo));
        }

        [Test]
        public void MetaArchivoShouldNotHaveFieldsConfigurated()
        {
            var specToTest = new HasFieldsConfiguratedSpecification();

            var metaArchivo = new MetaArchivo();

            Assert.IsTrue(specToTest
                               .Not()
                               .IsSatisfiedBy(metaArchivo));

            IDictionary<string, string> invalidationMessages = specToTest.GetInvalidationMessages(metaArchivo);

            Assert.AreEqual(invalidationMessages["HasFieldsConfiguratedSpecification"], "Debe seleccionar al menos un campo.");
        }

        [Test]
        public void MetaArchivoShouldHaveKeyFieldConfigurated()
        {
            var specToTest = new HasKeyFieldSpecification();

            var metaArchivo = new MetaArchivo();

            Assert.IsFalse(specToTest
                            .IsSatisfiedBy(metaArchivo));
        }

        [Test]
        public void MetaArchivoShouldNotHaveKeyFieldConfigurated()
        {
            var specToTest = new HasKeyFieldSpecification();

            var metaArchivo = new MetaArchivo();

            Assert.IsTrue(specToTest
                            .Not()
                            .IsSatisfiedBy(metaArchivo));

            IDictionary<string, string> invalidationMessages = specToTest.GetInvalidationMessages(metaArchivo);

            Assert.AreEqual(invalidationMessages["HasKeyFieldSpecification"], "Debe seleccionar al menos un campo como identificador.");
        }

    }
}
