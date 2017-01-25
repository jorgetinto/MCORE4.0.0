using NUnit.Framework;
using WatiN.Core;

namespace Cobranza.Core.MvcApplication.Tests.UITests
{
    [TestFixture, RequiresSTA]
    public class MetaArchivosSmokeTests
    {
        [Test]
        public void ShouldVerifyLoadedCustomers()
        {
            using (var browser = new IE("http://sistemas.llacruz.cl/eRec2ieDesa/MetaArchivos"))
            {
                SelectList codigoCliente = browser.ElementOfType<SelectList>(s => s.Id == "CodigoCliente");

                Assert.That(codigoCliente, Is.Not.Null);

                Assert.That(codigoCliente.Options, Is.Not.Empty);
            }
        }
    }
}