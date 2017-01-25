using System;
using System.Collections.Generic;
using Cobranza.ImporteExporte.Domain.ErecModule.Aggregates.ClienteAgg;
using Cobranza.ImporteExporte.Domain.ErecModule.Aggregates.CuotaAgg;
using Cobranza.ImporteExporte.Domain.ErecModule.Aggregates.EstadoDeudaAgg;
using Cobranza.ImporteExporte.Domain.ProcesoCargaModule.Aggregates.MetaCampoAgg;
using Cobranza.ImporteExporte.Domain.ProcesoCargaModule.Aggregates.RegistroCargadoAgg;
using Cobranza.ImporteExporte.Domain.Tests.ProcesoCargaModule;
using Cobranza.ImporteExporte.Domain.Tests.TestDataBuilders;

namespace Cobranza.ImporteExporte.Domain.Tests.ObjectMother
{
    public static class IpChileCuotaDomainServiceTestsObjectMother
    {
        private static readonly RegistroCargadoTestDataBuilder RegistroCargadoTestDataBuilder;

        private static readonly CampoCargadoTestDataBuilder CampoCargadoTestDataBuilder;

        private static readonly MetaCampoArchivoTestDataBuilder MetaCampoArchivoTestDataBuilder;

        private static readonly MetaCampoTestDataBuilder MetaCampoTestDataBuilder;

        static IpChileCuotaDomainServiceTestsObjectMother()
        {
            IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder = new RegistroCargadoTestDataBuilder();

            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder = new CampoCargadoTestDataBuilder();

            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder = new MetaCampoArchivoTestDataBuilder();

            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder = new MetaCampoTestDataBuilder();
        }

        public static RegistroCargado CreateRegistroCargadoForFeeShouldBeGeneratedFromRegistroCargado()
        {
            return IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("rut_deudor")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(8)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("RutDeudor")
                                        .Build())
                                .WithLargo(15)
                                .Build())
                        .WithValor("19006220")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("tipo_documento")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(54)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("TipoDocumento")
                                        .Build())
                                .Build())
                        .WithValor("mandato")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("nro_documento")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(44)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("NumeroDocumento")
                                        .Build())
                                .Build())
                        .WithValor("327773")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("nro_cuota")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(45)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("NumeroCuota")
                                        .Build())
                                .Build())
                        .WithValor("11")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("monto_cuota")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(51)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("ValorCuota")
                                        .Build())
                                .Build())
                        .WithValor("143640")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("dicom_firmante")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(65)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("Adicional1")
                                        .Build())
                                .Build())
                        .WithValor("0")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("Honorarios_abogado")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(66)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("GastosProtestos")
                                        .Build())
                                .Build())
                        .WithValor("0")
                        .Build())
                .WithCampoCargado(
                    IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                        .WithMetaCampoArchivo(
                            IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                .WithCampoArchivo("fecha_vencimiento")
                                .WithMetaCampo(
                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoTestDataBuilder
                                        .WithCodigoCliente("1900")
                                        .WithIdMetaCampo(49)
                                        .WithIdTablaSistema(2)
                                        .WithNombreFisicoAplicacion("FechaVencimiento")
                                        .Build())
                                .Build())
                        .WithValor("05-01-2016")
                        .Build())
                .Build();
        }

        public static Cuota CreateCuotaExpectedForFeeShouldBeGeneratedFromRegistroCargado()
        {
            return new Cuota
            {
                RutDeudor = "19006220-1",

                TipoDocumento = "5",

                NumeroDocumento = "327773",

                NumeroCuota = 11,

                ValorCuota = 143640,

                Adicional1 = "0",

                GastosProtestos = 0,

                FechaVencimiento = new DateTime(2016, 01, 05),

                RegistroCargado = new RegistroCargado()
            };
        }

        public static Cuota CreateFeeForFeeShouldBeLoanOrScholarship()
        {
            return new Cuota
            {
                RutDeudor = "12813510-3",

                TipoDocumento = "5",

                NumeroDocumento = "4000010",

                NumeroCuota = 1,

                ValorCuota = 914994,

                Adicional1 = "2750",

                GastosProtestos = 0,

                FechaVencimiento = new DateTime(2015, 02, 15),

                RegistroCargado = new RegistroCargado()
            };
        }

        public static Cuota CreateFeeForFeeShouldNotBeLoanOrScholarship()
        {
            return new Cuota
            {
                RutDeudor = "16417256-2",

                TipoDocumento = "5",

                NumeroDocumento = "340820",

                NumeroCuota = 9,

                ValorCuota = 42990,

                Adicional1 = "2750",

                GastosProtestos = 0,

                FechaVencimiento = new DateTime(2015, 11, 10),

                RegistroCargado = new RegistroCargado()
            };
        }

        public static Cuota CreateFeeShouldBeLessOrEqualThanRemainder()
        {
            return new Cuota
            {
                RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                    .WithCampoCargado(
                        IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                            .WithMetaCampoArchivo(
                                IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                    .WithCampoArchivo("monto_cuota")
                                    .WithIdMetaCampo(MetaCampo.IdMetaCampoValorCuota)
                                    .Build())
                            .WithValor("199000")
                            .Build())
                    .WithCampoCargado(
                        IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                            .WithMetaCampoArchivo(
                                IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                    .WithCampoArchivo("Abono_cuota")
                                    .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                    .Build())
                            .WithValor("138944")
                            .Build())
                    .Build()
            };
        }

        public static Cuota CreateFeeShouldNotBeLessOrEqualThanRemainder()
        {
            return new Cuota
            {
                RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                    .WithCampoCargado(
                        IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                            .WithMetaCampoArchivo(
                                IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                    .WithCampoArchivo("monto_cuota")
                                    .WithIdMetaCampo(MetaCampo.IdMetaCampoValorCuota)
                                    .Build())
                            .WithValor("105000")
                            .Build())
                    .WithCampoCargado(
                        IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                            .WithMetaCampoArchivo(
                                IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                    .WithCampoArchivo("Abono_cuota")
                                    .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                    .Build())
                            .WithValor("125000")
                            .Build())
                    .Build()
            };
        }

        public static Cuota CreateFeeShouldHaveDueDateFrom2015()
        {
            return new Cuota { FechaVencimiento = new DateTime(2015, 01, 01), RegistroCargado = new RegistroCargado() };
        }

        public static Cuota CreateFeeShouldNotHaveDueDateFrom2015()
        {
            return new Cuota { FechaVencimiento = new DateTime(2014, 11, 25), RegistroCargado = new RegistroCargado() };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForDeductAsPaidOnCustomer()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    
                    NumeroDocumento = "360990",
                    
                    RutDeudor = "8742862",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    
                    NumeroDocumento = "360627",
                    
                    RutDeudor = "8310148",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForDeductAsPaidOnCustomer()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    
                    NumeroDocumento = "360990",
                    
                    RutDeudor = "8742862",

                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    
                    NumeroDocumento = "360627",
                    
                    RutDeudor = "8310148",

                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForDeductAsPaidOnCustomer()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    
                    NumeroDocumento = "360990",
                    
                    RutDeudor = "8742862",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    
                    NumeroDocumento = "360627",
                    
                    RutDeudor = "8310148",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    Saldo = 100996,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("55000")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    Saldo = 110990,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("83000")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    Saldo = 109996,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    Saldo = 116990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    Saldo = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 85000,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 100000,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineoOneActionToDoForUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "2750",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineOneActionToDoForUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "0",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineOneActionToDoForUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 4391,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineOneActionToDoForUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 0,
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 11, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2015, 01, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 11, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2015, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 11, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2015, 01, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },

                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("55000")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("83000")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldDeductAsPaidOnCustomer()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    
                    NumeroDocumento = "360990",
                    
                    RutDeudor = "8742862",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    
                    NumeroDocumento = "360627",
                    
                    RutDeudor = "8310148",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 11,
                    NumeroDocumento = "350183",
                    RutDeudor = "15350104",
                    ValorCuota = 93630,
                    Saldo = 90630,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("38238")
                                                .Build())
                                        .Build()
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "332616",
                    RutDeudor = "14153113",
                    ValorCuota = 132990,
                    Saldo = 130990,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("19585")
                                                .Build())
                                        .Build()
                },

                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "999999",
                    RutDeudor = "15885083",
                    ValorCuota = 205000,
                    Saldo = 205000,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 11,
                    NumeroDocumento = "350183",
                    RutDeudor = "15350104",
                    ValorCuota = 93630,
                    Saldo = 93630,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "332616",
                    RutDeudor = "14153113",
                    ValorCuota = 132990,
                    Saldo = 132990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "999999",
                    RutDeudor = "15885083",
                    ValorCuota = 205000,
                    Saldo = 205000,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldApplyPaymentToExistingFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 11,
                    NumeroDocumento = "350183",
                    RutDeudor = "15350104",
                    ValorCuota = 93630,
                    Saldo = 90630,
                    FechaEstado = DateTime.Now,
                    CodigoEstadoDeuda = EstadoDeuda.CodigoEstadoDeudaAbonoEnCliente,
                    Observacion = "ABONO POR " + IpChileAccionDomainServiceTests.IdUsuario.ToString()
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "332616",
                    RutDeudor = "14153113",
                    ValorCuota = 132990,
                    Saldo = 130990,
                    FechaEstado = DateTime.Now,
                    CodigoEstadoDeuda = EstadoDeuda.CodigoEstadoDeudaAbonoEnCliente,
                    Observacion = "ABONO POR " + IpChileAccionDomainServiceTests.IdUsuario.ToString()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 85000,
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 100000,
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 109996,

                    EstadoDeuda = new EstadoDeuda() { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 116990,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldUpdateFeeValue()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 9,
                    NumeroDocumento = "360990",
                    RutDeudor = "8742862",
                    ValorCuota = 85000,
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "360627",
                    RutDeudor = "8310148",
                    ValorCuota = 100000,
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "2750",
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    Adicional1 = "0",

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldUpdateDicomSignatory()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    Adicional1 = "2750",
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 4391,
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    GastosProtestos = 0,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldUpdateLawyerFee()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    GastosProtestos = 4391,
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 11, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2015, 01, 30),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                },
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldExtendFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "364976",
                    RutDeudor = "17739403",
                    ValorCuota = 107990,
                    FechaVencimiento = new DateTime(2016, 03, 20),

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldLoadFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 2,
                    NumeroDocumento = "8083000",
                    RutDeudor = "15970992",
                    ValorCuota = 40526,
                    FechaVencimiento = new DateTime(2015, 12, 30),
                    RegistroCargado = new RegistroCargado()
                },

                new Cuota
                {
                    NumeroCuota = 4,
                    NumeroDocumento = "1324575",
                    RutDeudor = "15983752",
                    ValorCuota = 43912,
                    FechaVencimiento = new DateTime(2016, 01, 30),
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 11,
                    NumeroDocumento = "350183",
                    RutDeudor = "15350104",
                    ValorCuota = 93630,
                    Saldo = 55392,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("38238")
                                                .Build())
                                        .Build()
                },

                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "332616",
                    RutDeudor = "14153113",
                    ValorCuota = 132990,
                    Saldo = 113405,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("19585")
                                                .Build())
                                        .Build()
                },

                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "999999",
                    RutDeudor = "15885083",
                    ValorCuota = 205000,
                    Saldo = 205000,
                    RegistroCargado = IpChileCuotaDomainServiceTestsObjectMother.RegistroCargadoTestDataBuilder
                                        .WithCampoCargado(
                                            IpChileCuotaDomainServiceTestsObjectMother.CampoCargadoTestDataBuilder
                                                .WithMetaCampoArchivo(
                                                    IpChileCuotaDomainServiceTestsObjectMother.MetaCampoArchivoTestDataBuilder
                                                        .WithCampoArchivo("Abono_cuota")
                                                        .WithIdMetaCampo(MetaCampo.IdMetaCampoAbonoCuota)
                                                        .Build())
                                                .WithValor("0")
                                                .Build())
                                        .Build()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateCurrentFeesForIpChileAccionDomainServiceShouldApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 1,
                    NumeroDocumento = "999999",
                    RutDeudor = "15885083",
                    ValorCuota = 205000,
                    Saldo = 205000,

                    EstadoDeuda = new EstadoDeuda { Activo = 1 }
                }
            };
        }

        public static ICollection<Cuota>
            CreateExpectedFeesForIpChileAccionDomainServiceShouldApplyPaymentToNewFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroCuota = 11,
                    NumeroDocumento = "350183",
                    RutDeudor = "15350104",
                    ValorCuota = 93630,
                    Saldo = 55392,
                    FechaEstado = DateTime.Now,
                    CodigoEstadoDeuda = EstadoDeuda.CodigoEstadoDeudaAbonoEnCliente,
                    Observacion = "ABONO POR " + IpChileAccionDomainServiceTests.IdUsuario.ToString()
                },
                new Cuota
                {
                    NumeroCuota = 10,
                    NumeroDocumento = "332616",
                    RutDeudor = "14153113",
                    ValorCuota = 132990,
                    Saldo = 113405,
                    FechaEstado = DateTime.Now,
                    CodigoEstadoDeuda = EstadoDeuda.CodigoEstadoDeudaAbonoEnCliente,
                    Observacion = "ABONO POR " + IpChileAccionDomainServiceTests.IdUsuario.ToString()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForReactivateFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroDocumento = "234495",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18728496",
                    RegistroCargado = new RegistroCargado()
                },
                new Cuota
                {
                    NumeroDocumento = "240291",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18534999",
                    RegistroCargado = new RegistroCargado()
                },
                new Cuota
                {
                    NumeroDocumento = "356789",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "15885083",
                    RegistroCargado = new RegistroCargado()
                },
                new Cuota
                {
                    NumeroDocumento = "412378",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "15885083",
                    RegistroCargado = new RegistroCargado()
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateInactiveFeesForIpChileAccionDomainServiceShouldDetermineTwoActionsToDoForReactivateFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroDocumento = "234495",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18728496",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2015, 01, 01)
                },
                new Cuota
                {
                    NumeroDocumento = "240291",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18534999",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2015, 01, 01)
                },
                new Cuota
                {
                    NumeroDocumento = "356789",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "15885083",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2014, 01, 01)
                },
                new Cuota
                {
                    NumeroDocumento = "412378",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "15885083",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2015, 12, 01)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateConvertedFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForReactivateFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroDocumento = "234495",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18728496",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 02, 02)
                },
                new Cuota
                {
                    NumeroDocumento = "240291",
                    NumeroCuota = 1,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "18534999",
                    RegistroCargado = new RegistroCargado(),
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }

        public static IEnumerable<Cuota>
            CreateInactiveFeesForIpChileAccionDomainServiceShouldDetermineZeroActionsToDoForReactivateFees()
        {
            return new List<Cuota>
            {
                new Cuota
                {
                    NumeroDocumento = "326842",
                    NumeroCuota = 7,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "17133830",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2015, 02, 02)
                },
                new Cuota
                {
                    NumeroDocumento = "327231",
                    NumeroCuota = 9,
                    CodigoCliente = Cliente.CodigoClienteIpChile,
                    RutDeudor = "12106304",
                    CodigoEstadoDeuda = "3",
                    EstadoDeuda = new EstadoDeuda { Activo = 0 },
                    FechaVencimiento = new DateTime(2015, 03, 02)
                }
            };
        }
    }
}