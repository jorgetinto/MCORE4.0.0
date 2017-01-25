using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.ValidationSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg
{
    public class MetaArchivoValidator
        : IMetaArchivoValidator
    {
        private readonly HasFieldsConfiguratedSpecification hasFieldsConfiguratedSpecification;

        private bool satisfyHasFieldsConfiguratedSpecification;

        private readonly HasKeyFieldSpecification hasKeyFieldSpecification;

        private bool satisfyHasKeyFieldSpecification;

        private IDictionary<string, string> lastInvalidationMessages;

        public MetaArchivoValidator()
        {
            this.hasFieldsConfiguratedSpecification = new HasFieldsConfiguratedSpecification();

            this.hasKeyFieldSpecification = new HasKeyFieldSpecification();

            this.lastInvalidationMessages = new Dictionary<string, string>();
        }

        public IDictionary<string, string> LastInvalidationMessages
        {
            get { return this.lastInvalidationMessages; }
        }

        public bool IsValidForCreate(MetaArchivo metaArchivoToAdd, MetaArchivo actual)
        {
            this.lastInvalidationMessages.Clear();

            if (metaArchivoToAdd == null)
            {
                return false;
            }

            bool satisfyFundamentalValidations = this.SatisfyFundamentalValidations(metaArchivoToAdd);

            if (!satisfyFundamentalValidations)
            {
                this.SetLastInvalidationMessages(metaArchivoToAdd);
            }

            MetaArchivoDuplicatedSpecification metaArchivoDuplicatedSpecification =
                new MetaArchivoDuplicatedSpecification();

            bool isDuplicated = metaArchivoDuplicatedSpecification.IsSatisfiedBy(actual);

            if (isDuplicated)
            {
                this.lastInvalidationMessages = this.lastInvalidationMessages
                                                    .Concat(metaArchivoDuplicatedSpecification
                                                    .GetInvalidationMessages(actual))
                                                    .ToDictionary(k => k.Key, v => v.Value);
            }

            return satisfyFundamentalValidations &&
                !isDuplicated;
        }

        public bool IsValidForEdit(MetaArchivo metaArchivoToEdit, MetaArchivo actual)
        {
            if (actual == null)
            {
                throw new ArgumentNullException("actual");
            }

            bool satisfyFundamentalValidations = this.IsValidForCreate(metaArchivoToEdit, null);

            InitDateGreaterThanSpecification initDateGreaterThanSpecification =
                new InitDateGreaterThanSpecification("FechaInicio", actual.FechaInicio);

            bool satisfyInitDateValidation = initDateGreaterThanSpecification.IsSatisfiedBy(metaArchivoToEdit);

            if (!satisfyInitDateValidation)
            {
                this.lastInvalidationMessages = this.lastInvalidationMessages
                                                    .Concat(initDateGreaterThanSpecification
                                                    .GetInvalidationMessages(metaArchivoToEdit))
                                                    .ToDictionary(k => k.Key, v => v.Value);
            }

            return satisfyFundamentalValidations &&
                satisfyInitDateValidation;
        }

        private bool SatisfyFundamentalValidations(MetaArchivo metaArchivo)
        {
            this.satisfyHasFieldsConfiguratedSpecification = this.hasFieldsConfiguratedSpecification
                                                                    .IsSatisfiedBy(metaArchivo);

            this.satisfyHasKeyFieldSpecification = this.hasKeyFieldSpecification.IsSatisfiedBy(metaArchivo);

            return this.satisfyHasFieldsConfiguratedSpecification &&
                this.satisfyHasKeyFieldSpecification;
        }

        private void SetLastInvalidationMessages(MetaArchivo metaArchivo)
        {
            if (!this.satisfyHasFieldsConfiguratedSpecification)
            {
                this.lastInvalidationMessages = this.lastInvalidationMessages
                                                    .Concat(this.hasFieldsConfiguratedSpecification
                                                    .GetInvalidationMessages(metaArchivo))
                                                    .ToDictionary(k => k.Key, v => v.Value);
            }

            if (!this.satisfyHasKeyFieldSpecification)
            {
                this.lastInvalidationMessages = this.lastInvalidationMessages
                                                    .Concat(this.hasKeyFieldSpecification
                                                    .GetInvalidationMessages(metaArchivo))
                                                    .ToDictionary(k => k.Key, v => v.Value);
            }
        }
    }
}
