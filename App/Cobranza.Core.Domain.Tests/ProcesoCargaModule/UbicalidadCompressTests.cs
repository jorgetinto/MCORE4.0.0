using System.Collections.Generic;
using System.Linq;
using Cobranza.ImporteExporte.Domain.ProcesoCargaModule.Aggregates.UbicabilidadAgg;
using NUnit.Framework;

namespace Cobranza.ImporteExporte.Domain.Tests.ProcesoCargaModule
{
    [TestFixture]
    public class UbicalidadCompressTests
    {
        [Test]
        [TestCase("111111111", "111111111", "111111111", null)]
        [TestCase("correo1@gmail.com", "correo1@gmail.com", "correo1@gmail.com", null)]
        [TestCase("111111111", "222222222", "111111111", "222222222")]
        [TestCase("111111111", null, "111111111", null)]
        [TestCase("111111111", "", "111111111", null)]
        public void ShouldConvertRegistroCargadoWithPhone3ToUbicabilidadCompress(
                                            string valorDato1,
                                            string valorDato2,
                                            string valorResultado1,
                                            string valorResultado2)
        {
            ICollection<Ubicabilidad> ubicabilidadesToCompress = new List<Ubicabilidad>
            {
                new Ubicabilidad 
                {
                    RutDeudor = "15885083-4",

                    Dato = valorDato1,

                    IdMedioUbicabilidad = 1,

                    IdTipoContacto = 1
                },

                new Ubicabilidad 
                {
                    RutDeudor = "15885083-4",

                    Dato = valorDato2,

                    IdMedioUbicabilidad = 1,

                    IdTipoContacto = 1
                }
            };

            ICollection<Ubicabilidad> expected = new List<Ubicabilidad>
            {
                new Ubicabilidad 
                {
                    RutDeudor = "15885083-4",

                    Dato = valorResultado1,

                    IdMedioUbicabilidad = 1,

                    IdTipoContacto = 1
                }
            };

            if (!string.IsNullOrEmpty(valorResultado2))
            {
                expected.Add(new Ubicabilidad
                {
                    RutDeudor = "15885083-4",

                    Dato = valorResultado2,

                    IdMedioUbicabilidad = 1,

                    IdTipoContacto = 1
                });
            }

            IUbicabilidadCompresor<Ubicabilidad> sut = new UbicabilidadCompresor();

            IEnumerable<Ubicabilidad> actual = sut.CompressFrom(ubicabilidadesToCompress);

            for (int i = 0; i < actual.Count(); i++)
            {
                Assert.That(actual.ElementAt(i), Is.EqualTo(expected.ElementAt(i)));
            }
        }
    }
}
