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
            obsCollection.OMSourceId = obsCollectionID;

            //Create the phenomenon information
            DateTime dt = new DateTime(Int32.Parse(ndbRecord.DateClassed.Substring(0, 4)), Int32.Parse(ndbRecord.DateClassed.Substring(4, 2)), Int32.Parse(ndbRecord.DateClassed.Substring(6, 2)));
            TimeScope phenTime = new TimeScope();
            phenTime.DateContext = DateContextEnum.PhenomenonTime;
            phenTime.TimeStamp1 = dt;
            obsCollection.TimeScopes.Add(phenTime);

            Obs colorGrade = new Obs();
            colorGrade.TimeScopes.Add(phenTime);
            colorGrade.OMCode = "A_YLD_USDA_1GOSG_OFFICIAL_COLOR_GRADE";
            colorGrade.Value = ndbRecord.OfficialColorGrade;
            colorGrade.UoMCode = "";
            obsCollection.ObsIds.Add(colorGrade.Id.ReferenceId);
            _obs.Add(colorGrade);

            Obs stapleLength = new Obs();
            stapleLength.TimeScopes.Add(phenTime);
            stapleLength.OMCode = "A_YLD_USDA_1GOSG_STAPLE_LENGTH";
            stapleLength.Value = ndbRecord.StapleLength;
            stapleLength.UoMCode = "";
            obsCollection.ObsIds.Add(stapleLength.Id.ReferenceId);
            _obs.Add(stapleLength);

            Obs micronaire = new Obs();
            micronaire.TimeScopes.Add(phenTime);
            micronaire.OMCode = "A_YLD_USDA_1GOSG_MICRONAIRE";
            micronaire.Value = ndbRecord.Micronaire;
            micronaire.UoMCode = "";
            obsCollection.ObsIds.Add(micronaire.Id.ReferenceId);
            _obs.Add(micronaire);

            Obs strength = new Obs();
            strength.TimeScopes.Add(phenTime);
            strength.OMCode = "A_YLD_USDA_1GOSG_STRENGTH";
            strength.Value = ndbRecord.Strength;
            strength.UoMCode = "";
            obsCollection.ObsIds.Add(strength.Id.ReferenceId);
            _obs.Add(strength);

            Obs leafGrade = new Obs();
            leafGrade.TimeScopes.Add(phenTime);
            leafGrade.OMCode = "A_YLD_USDA_1GOSG_LEAF_GRADE";
            leafGrade.Value = ndbRecord.LeafGrade;
            leafGrade.UoMCode = "";
            obsCollection.ObsIds.Add(leafGrade.Id.ReferenceId);
            _obs.Add(leafGrade);

            Obs extraneousMatter = new Obs();
            extraneousMatter.TimeScopes.Add(phenTime);
            extraneousMatter.OMCode = "A_YLD_USDA_1GOSG_EXTRANEOUS_MATTER";
            extraneousMatter.Value = ndbRecord.ExtraneousMatter;
            extraneousMatter.UoMCode = "";
            obsCollection.ObsIds.Add(extraneousMatter.Id.ReferenceId);
            _obs.Add(extraneousMatter);

            Obs HVIColorGrade = new Obs();
            HVIColorGrade.TimeScopes.Add(phenTime);
            HVIColorGrade.OMCode = "A_YLD_USDA_1GOSG_HVI_COLOR_GRADE";
            HVIColorGrade.Value = ndbRecord.HVIColorGrade;
            HVIColorGrade.UoMCode = "";
            obsCollection.ObsIds.Add(HVIColorGrade.Id.ReferenceId);
            _obs.Add(HVIColorGrade);

            Obs colorQuadrant = new Obs();
            colorQuadrant.TimeScopes.Add(phenTime);
            colorQuadrant.OMCode = "A_YLD_USDA_1GOSG_HVI_COLOR_QUADRANT";
            colorQuadrant.Value = ndbRecord.ColorQuadrant;
            colorQuadrant.UoMCode = "";
            obsCollection.ObsIds.Add(colorQuadrant.Id.ReferenceId);
            _obs.Add(colorQuadrant);

            Obs rd = new Obs();
            rd.TimeScopes.Add(phenTime);
            rd.OMCode = "A_YLD_USDA_1GOSG_HVI_REFLECTANCE";
            rd.Value = ndbRecord.RD;
            rd.UoMCode = "";
            obsCollection.ObsIds.Add(rd.Id.ReferenceId);
            _obs.Add(rd);

            Obs B = new Obs();
            B.TimeScopes.Add(phenTime);
            B.OMCode = "A_YLD_USDA_1GOSG_HVI_YELLOWNESS";
            B.Value = ndbRecord.B;
            B.UoMCode = "";
            obsCollection.ObsIds.Add(B.Id.ReferenceId);
            _obs.Add(B);

            Obs nonLintContent = new Obs();
            nonLintContent.TimeScopes.Add(phenTime);
            nonLintContent.OMCode = "A_YLD_USDA_1GOSG_TRASH_PERCENT_AREA";
            nonLintContent.Value = ndbRecord.NonLintContent;
            nonLintContent.UoMCode = "";
            obsCollection.ObsIds.Add(nonLintContent.Id.ReferenceId);
            _obs.Add(nonLintContent);

            Obs fiberLength = new Obs();
            fiberLength.TimeScopes.Add(phenTime);
            fiberLength.OMCode = "A_YLD_FIBER_LENGTH";
            fiberLength.Value = ndbRecord.FiberLength;
            fiberLength.UoMCode = "";
            obsCollection.ObsIds.Add(fiberLength.Id.ReferenceId);
            _obs.Add(fiberLength);

            Obs lengthUniformity = new Obs();
            lengthUniformity.TimeScopes.Add(phenTime);
            lengthUniformity.OMCode = "A_YLD_USDA_1GOSG_LENGTH_UNIFORMITY_INDEX";
            lengthUniformity.Value = ndbRecord.LengthUniformity;
            lengthUniformity.UoMCode = "";
            obsCollection.ObsIds.Add(lengthUniformity.Id.ReferenceId);
            _obs.Add(lengthUniformity);

            ObsCodeComponent UplandOrPima = new ObsCodeComponent();
            UplandOrPima.ComponentCode = "CC_FOI_CROP";
            UplandOrPima.ComponentType = "FEATURE_OF_INTEREST";
            UplandOrPima.Selector = "CROP";
            UplandOrPima.Description = "The ratio between the mean length and the upperhalf mean length of the fibers, expressed as a percentage.";
            
            if(ndbRecord.UplandOrPima == "1")
            {
                UplandOrPima.Value = "GOSHI";
            }
            else
            {
                UplandOrPima.Value = "GOSBA";
            }

            UplandOrPima.ValueType = OMCodeComponentValueTypeEnum.String;
            UplandOrPima.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(UplandOrPima);

            Obs remarks = new Obs();
            remarks.TimeScopes.Add(phenTime);
            remarks.OMCode = "US_USDA_1GOSG_REMARKS";
            remarks.Value = ndbRecord.Remarks;
            remarks.UoMCode = "";
            obsCollection.ObsIds.Add(remarks.Id.ReferenceId);
            _obs.Add(remarks);

            ObsCodeComponent recordType = new ObsCodeComponent();
            recordType.ComponentCode = "US_USDA_1GOSG_RECORD_TYPE";
            recordType.ComponentType = "FEATURE_OF_INTEREST";
            recordType.Selector = "RECORD_TYPE";
            recordType.Description = "This one-digit code indicates the type of record.";

            if (ndbRecord.RecordType == "0")
            {
                recordType.Value = "Original";
            }
            else if(ndbRecord.RecordType == "1")
            {
                recordType.Value = "Review";
            }
            else
            {
                recordType.Value = "Rework";
            }

            recordType.ValueType = OMCodeComponentValueTypeEnum.String;
            recordType.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(recordType);


            ObsCodeComponent recordStatus = new ObsCodeComponent();
            recordStatus.ComponentCode = "US_USDA_1GOSG_RECORD_STATUS";
            recordStatus.ComponentType = "FEATURE_OF_INTEREST";
            recordStatus.Selector = "RECORD_STATUS";
            recordStatus.Description = "This one-digit code indicates the type of record.";

            if (ndbRecord.RecordStatus == "0")
            {
                recordStatus.Value = "Not a correction";
            }
            else
            {
                recordStatus.Value = "Correction";
            }

            recordStatus.ValueType = OMCodeComponentValueTypeEnum.String;
            recordStatus.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(recordStatus);

            return obsCollection;
        }

        public static AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load MapNDBRecord(PublisherDataModel.NDBRecord ndbRecord, AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load load)
        {
            //Transform the native object into the ADAPT object
            ContextItem record = new ContextItem();
            record.Code = "US_USDA-COT-NDB";

            //Transform the native object into the ADAPT object
            ContextItem GINCode = new ContextItem();
            GINCode.Code = "US_USDA-COT-GinCode";
            GINCode.Value = ndbRecord.GINCode;
            record.NestedItems.Add(GINCode);

            ContextItem GINBale = new ContextItem();
            GINBale.Code = "US_USDA-COT-GinBaleID";
            GINBale.Value = ndbRecord.GINBale;
            record.NestedItems.Add(GINBale);

            ContextItem DateClassed = new ContextItem();
            DateClassed.Code = "US_USDA-COT-DateClassed";
            DateClassed.Value = ndbRecord.DateClassed;
            record.NestedItems.Add(DateClassed);

            ContextItem ReportingBasis = new ContextItem();
            ReportingBasis.Code = "US_USDA-COT-ReportingBasis";
            ReportingBasis.Value = ndbRecord.ReportingBasis;
            record.NestedItems.Add(ReportingBasis);

            ContextItem ModuleTrailerNumber = new ContextItem();
            ModuleTrailerNumber.Code = "US_USDA-COT-ModuleTrailerNumber";
            ModuleTrailerNumber.Value = ndbRecord.ModuleTrailerNumber;
            record.NestedItems.Add(ModuleTrailerNumber);

            ContextItem NumberOfBales = new ContextItem();
            NumberOfBales.Code = "US_USDA-COT-NumberOfBales";
            NumberOfBales.Value = ndbRecord.NumberOfBales;
            record.NestedItems.Add(NumberOfBales);

            ContextItem CCCLoan = new ContextItem();
            CCCLoan.Code = "US_USDA_1GOSG_LOAN_PREMIUM";
            CCCLoan.Value = ndbRecord.CCCLoan;
            record.NestedItems.Add(CCCLoan);

            load.ContextItems.Add(record);

            return load;
        }
    }
}