using AgGateway.ADAPT.ApplicationDataModel.ADM;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Logistics;
using AgGateway.ADAPT.ApplicationDataModel.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AgGateway.ADAPT.ApplicationDataModel.Documents;

namespace CottonClassingPlugin.DataMappers
{
    public class NDBRecordMapper
    {
        public static AgGateway.ADAPT.ApplicationDataModel.Documents.ObsCollection MapNDBRecordObsCollection(PublisherDataModel.NDBRecord ndbRecord, List<AgGateway.ADAPT.ApplicationDataModel.Documents.Obs> _obs, int obsCollectionID, AgGateway.ADAPT.ApplicationDataModel.Documents.ObsCollection obsCollection, ObsDataset obsDataset, ApplicationDataModel adm)
        {
            int obsIndex = 1;
            obsCollection.OMSourceId = obsCollectionID;

            Obs OfficialColorGrade = new Obs();
            OfficialColorGrade.OMSourceId = obsIndex; obsIndex++;
            OfficialColorGrade.UoMCode = "USDA-COT-OfficialColorGrade";
            OfficialColorGrade.Value = ndbRecord.OfficialColorGrade;
            obsCollection.ObsIds.Add(OfficialColorGrade.Id.ReferenceId);
            _obs.Add(OfficialColorGrade);

            Obs StapleLength = new Obs();
            StapleLength.OMSourceId = obsIndex; obsIndex++;
            StapleLength.UoMCode = "USDA-COT-StapleLength";
            StapleLength.Value = ndbRecord.StapleLength;
            obsCollection.ObsIds.Add(StapleLength.Id.ReferenceId);
            _obs.Add(StapleLength);

            Obs Micronaire = new Obs();
            Micronaire.OMSourceId = obsIndex; obsIndex++;
            Micronaire.UoMCode = "USDA-COT-Micronaire";
            Micronaire.Value = ndbRecord.Micronaire;
            obsCollection.ObsIds.Add(Micronaire.Id.ReferenceId);
            _obs.Add(Micronaire);

            Obs Strength = new Obs();
            Strength.OMSourceId = obsIndex; obsIndex++;
            Strength.UoMCode = "USDA-COT-Strength";
            Strength.Value = ndbRecord.Strength;
            obsCollection.ObsIds.Add(Strength.Id.ReferenceId);
            _obs.Add(Strength);

            Obs LeafGrade = new Obs();
            LeafGrade.OMSourceId = obsIndex; obsIndex++;
            LeafGrade.UoMCode = "USDA-COT-LeafGrade";
            LeafGrade.Value = ndbRecord.LeafGrade;
            obsCollection.ObsIds.Add(LeafGrade.Id.ReferenceId);
            _obs.Add(LeafGrade);

            Obs ExtraneousMatter = new Obs();
            ExtraneousMatter.OMSourceId = obsIndex; obsIndex++;
            ExtraneousMatter.UoMCode = "USDA-COT-ExtraneousMatter";
            ExtraneousMatter.Value = ndbRecord.ExtraneousMatter;
            obsCollection.ObsIds.Add(ExtraneousMatter.Id.ReferenceId);
            _obs.Add(ExtraneousMatter);

            Obs Remarks = new Obs();
            Remarks.OMSourceId = obsIndex; obsIndex++;
            Remarks.UoMCode = "USDA-COT-Remarks";
            Remarks.Value = ndbRecord.Remarks;
            obsCollection.ObsIds.Add(Remarks.Id.ReferenceId);
            _obs.Add(Remarks);

            Obs HVIColorGrade = new Obs();
            HVIColorGrade.OMSourceId = obsIndex; obsIndex++;
            HVIColorGrade.UoMCode = "USDA-COT-HVIColorGrade";
            HVIColorGrade.Value = ndbRecord.HVIColorGrade;
            obsCollection.ObsIds.Add(HVIColorGrade.Id.ReferenceId);
            _obs.Add(HVIColorGrade);

            Obs ColorQuadrant = new Obs();
            ColorQuadrant.OMSourceId = obsIndex; obsIndex++;
            ColorQuadrant.UoMCode = "USDA-COT-ColorQuadrant";
            ColorQuadrant.Value = ndbRecord.ColorQuadrant;
            obsCollection.ObsIds.Add(ColorQuadrant.Id.ReferenceId);
            _obs.Add(ColorQuadrant);

            Obs RD = new Obs();
            RD.OMSourceId = obsIndex; obsIndex++;
            RD.UoMCode = "USDA-COT-Rd";
            RD.Value = ndbRecord.RD;
            obsCollection.ObsIds.Add(RD.Id.ReferenceId);
            _obs.Add(RD);

            Obs B = new Obs();
            B.OMSourceId = obsIndex; obsIndex++;
            B.UoMCode = "USDA-COT-b";
            B.Value = ndbRecord.B;
            obsCollection.ObsIds.Add(B.Id.ReferenceId);
            _obs.Add(B);

            Obs NonLintContent = new Obs();
            NonLintContent.OMSourceId = obsIndex; obsIndex++;
            NonLintContent.UoMCode = "USDA-COT-NonLintContent";
            NonLintContent.Value = ndbRecord.NonLintContent;
            obsCollection.ObsIds.Add(NonLintContent.Id.ReferenceId);
            _obs.Add(NonLintContent);

            Obs FiberStrength = new Obs();
            FiberStrength.OMSourceId = obsIndex; obsIndex++;
            FiberStrength.UoMCode = "USDA-COT-FiberLength";
            FiberStrength.Value = ndbRecord.FiberLength;
            obsCollection.ObsIds.Add(FiberStrength.Id.ReferenceId);
            _obs.Add(FiberStrength);

            Obs LengthUniformity = new Obs();
            LengthUniformity.OMSourceId = obsIndex; obsIndex++;
            LengthUniformity.UoMCode = "USDA-COT-LengthUniformityIndex";
            LengthUniformity.Value = ndbRecord.LengthUniformity;
            obsCollection.ObsIds.Add(LengthUniformity.Id.ReferenceId);
            _obs.Add(LengthUniformity);

            Obs UplandOrPima = new Obs();
            UplandOrPima.OMSourceId = obsIndex; obsIndex++;
            UplandOrPima.UoMCode = "USDA-COT-UplandPima";
            UplandOrPima.Value = ndbRecord.UplandOrPima;
            obsCollection.ObsIds.Add(UplandOrPima.Id.ReferenceId);
            _obs.Add(UplandOrPima);

            Obs RecordType = new Obs();
            RecordType.OMSourceId = obsIndex; obsIndex++;
            RecordType.UoMCode = "USDA-COT-RecordType";
            RecordType.Value = ndbRecord.RecordType;
            obsCollection.ObsIds.Add(RecordType.Id.ReferenceId);
            _obs.Add(RecordType);

            Obs RecordStatus = new Obs();
            RecordStatus.OMSourceId = obsIndex; obsIndex++;
            RecordStatus.UoMCode = "USDA-COT-RecordStatus";
            RecordStatus.Value = ndbRecord.RecordStatus;
            obsCollection.ObsIds.Add(RecordStatus.Id.ReferenceId);
            _obs.Add(RecordStatus);

            Obs CCCLoan = new Obs();
            CCCLoan.OMSourceId = obsIndex; obsIndex++;
            CCCLoan.UoMCode = "USDA-COT-CCCLoanPremium";
            CCCLoan.Value = ndbRecord.CCCLoan;
            obsCollection.ObsIds.Add(CCCLoan.Id.ReferenceId);
            _obs.Add(CCCLoan);

            return obsCollection;
        }

        public static AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load MapNDBRecord(PublisherDataModel.NDBRecord ndbRecord, AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load load)
        {
            //Transform the native object into the ADAPT object
            ContextItem record = new ContextItem();
            record.Code = "USDA-COT-NDB";

            //Transform the native object into the ADAPT object
            ContextItem GINCode = new ContextItem();
            GINCode.Code = "USDA-COT-GinCode";
            GINCode.Value = ndbRecord.GINCode;
            record.NestedItems.Add(GINCode);

            ContextItem GINBale = new ContextItem();
            GINBale.Code = "USDA-COT-GinBaleID";
            GINBale.Value = ndbRecord.GINBale;
            record.NestedItems.Add(GINBale);

            ContextItem DateClassed = new ContextItem();
            DateClassed.Code = "USDA-COT-DateClassed";
            DateClassed.Value = ndbRecord.DateClassed;
            record.NestedItems.Add(DateClassed);

            ContextItem ReportingBasis = new ContextItem();
            ReportingBasis.Code = "USDA-COT-ReportingBasis";
            ReportingBasis.Value = ndbRecord.ReportingBasis;
            record.NestedItems.Add(ReportingBasis);

            ContextItem ModuleTrailerNumber = new ContextItem();
            ModuleTrailerNumber.Code = "USDA-COT-ModuleTrailerNumber";
            ModuleTrailerNumber.Value = ndbRecord.ModuleTrailerNumber;
            record.NestedItems.Add(ModuleTrailerNumber);

            ContextItem NumberOfBales = new ContextItem();
            NumberOfBales.Code = "USDA-COT-NumberOfBales";
            NumberOfBales.Value = ndbRecord.NumberOfBales;
            record.NestedItems.Add(NumberOfBales);

            load.ContextItems.Add(record);

            return load;
        }
    }
}