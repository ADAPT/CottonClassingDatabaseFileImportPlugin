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

            ObsCodeComponent colorGrade = new ObsCodeComponent();
            colorGrade.ComponentCode = "A_YLD_USDA_1GOSG_OFFICIAL_COLOR_GRADE";
            colorGrade.ComponentType = "OBSERVED_PROPERTY";
            colorGrade.Selector = "A_OFFICIAL_COLOR_GRADE";
            colorGrade.Description = "The color grade of the cotton sample.";
            colorGrade.Value = ndbRecord.OfficialColorGrade;
            colorGrade.ValueType = OMCodeComponentValueTypeEnum.String;
            colorGrade.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(colorGrade);

            ObsCodeComponent stapleLength = new ObsCodeComponent();
            stapleLength.ComponentCode = "A_YLD_USDA_1GOSG_STAPLE_LENGTH";
            stapleLength.ComponentType = "OBSERVED_PROPERTY";
            stapleLength.Selector = "A_STAPLE_LENGTH";
            stapleLength.Description = "Fiber length expressed in 32nds of an inch.";
            stapleLength.Value = ndbRecord.StapleLength;
            stapleLength.ValueType = OMCodeComponentValueTypeEnum.String;
            stapleLength.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(stapleLength);

            ObsCodeComponent micronaire = new ObsCodeComponent();
            micronaire.ComponentCode = "A_YLD_1GOSG_MICRONAIRE";
            micronaire.ComponentType = "OBSERVED_PROPERTY";
            micronaire.Selector = "A_MICRONAIRE";
            micronaire.Description = "Micronaire is a measure of the cotton’s fineness and is reported to the nearest tenth.";
            micronaire.Value = ndbRecord.Micronaire;
            micronaire.ValueType = OMCodeComponentValueTypeEnum.String;
            micronaire.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(micronaire);

            ObsCodeComponent strength = new ObsCodeComponent();
            strength.ComponentCode = "A_YLD_USDA_1GOSG_STRENGTH";
            strength.ComponentType = "OBSERVED_PROPERTY";
            strength.Selector = "A_STENGTH";
            strength.Description = "Strength reported is the force in grams required to break a bundle of fibers one tex unit in size.";
            strength.Value = ndbRecord.Strength;
            strength.ValueType = OMCodeComponentValueTypeEnum.String;
            strength.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(strength);

            ObsCodeComponent leafGrade = new ObsCodeComponent();
            leafGrade.ComponentCode = "A_YLD_USDA_1GOSG_LEAF_GRADE";
            leafGrade.ComponentType = "OBSERVED_PROPERTY";
            leafGrade.Selector = "A_LEAF_GRADE";
            leafGrade.Description = "Leaf refers to particles of the cotton plant’s leaf which remain in the lint after the ginning process.";
            leafGrade.Value = ndbRecord.LeafGrade;
            leafGrade.ValueType = OMCodeComponentValueTypeEnum.String;
            leafGrade.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(leafGrade);

            ObsCodeComponent extraneousMatter = new ObsCodeComponent();
            extraneousMatter.ComponentCode = "A_YLD_USDA_1GOSG_EXTRANEOUS_MATTER";
            extraneousMatter.ComponentType = "OBSERVED_PROPERTY";
            extraneousMatter.Selector = "A_EXTRANEOUS_MATTER";
            extraneousMatter.Description = "Extraneous matter is any substance in the cotton other than fiber or leaf.";
            extraneousMatter.Value = ndbRecord.ExtraneousMatter;
            extraneousMatter.ValueType = OMCodeComponentValueTypeEnum.String;
            extraneousMatter.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(extraneousMatter);

            ObsCodeComponent HVIColorGrade = new ObsCodeComponent();
            HVIColorGrade.ComponentCode = "A_YLD_USDA_1GOSG_HVI_COLOR_GRADE";
            HVIColorGrade.ComponentType = "OBSERVED_PROPERTY";
            HVIColorGrade.Selector = "A_HVI_COLOR_GRADE";
            HVIColorGrade.Description = "The same color grade as the official color grade.";
            HVIColorGrade.Value = ndbRecord.HVIColorGrade;
            HVIColorGrade.ValueType = OMCodeComponentValueTypeEnum.String;
            HVIColorGrade.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(HVIColorGrade);

            ObsCodeComponent colorQuadrant = new ObsCodeComponent();
            colorQuadrant.ComponentCode = "A_YLD_USDA_1GOSG_HVI_COLOR_GRADE";
            colorQuadrant.ComponentType = "OBSERVED_PROPERTY";
            colorQuadrant.Selector = "A_HVI_COLOR_GRADE";
            colorQuadrant.Description = "Color grade subdivisions are reported as Color Quadrants.";
            colorQuadrant.Value = ndbRecord.ColorQuadrant;
            colorQuadrant.ValueType = OMCodeComponentValueTypeEnum.String;
            colorQuadrant.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(colorQuadrant);

            ObsCodeComponent RD = new ObsCodeComponent();
            RD.ComponentCode = "A_YLD_USDA_1GOSG_REFLECTANCE";
            RD.ComponentType = "OBSERVED_PROPERTY";
            RD.Selector = "A_HVI_COLOR_GRADE";
            RD.Description = "HVI Rd (% reflectance).";
            RD.Value = ndbRecord.RD;
            RD.ValueType = OMCodeComponentValueTypeEnum.String;
            RD.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(RD);

            ObsCodeComponent B = new ObsCodeComponent();
            B.ComponentCode = "A_YLD_USDA_1GOSG_HVI_YELLOWNESS";
            B.ComponentType = "OBSERVED_PROPERTY";
            B.Selector = "A_HVI_YELLOWNESS";
            B.Description = "HVI +b (yellowness).";
            B.Value = ndbRecord.B;
            B.ValueType = OMCodeComponentValueTypeEnum.String;
            B.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(B);

            ObsCodeComponent nonLintContent = new ObsCodeComponent();
            nonLintContent.ComponentCode = "A_YLD_USDA_1GOSG_TRASH_PERCENT_AREA";
            nonLintContent.ComponentType = "OBSERVED_PROPERTY";
            nonLintContent.Selector = "A_TRASH_PERCENT_AREA";
            nonLintContent.Description = "The percent of the sample surface covered by trash particles as determined by the instrument to the nearest tenth.";
            nonLintContent.Value = ndbRecord.NonLintContent;
            nonLintContent.ValueType = OMCodeComponentValueTypeEnum.String;
            nonLintContent.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(nonLintContent);

            ObsCodeComponent fiberLength = new ObsCodeComponent();
            fiberLength.ComponentCode = "A_YLD_FIBER_LENGTH";
            fiberLength.ComponentType = "OBSERVED_PROPERTY";
            fiberLength.Selector = "A_FIBER_LENGTH";
            fiberLength.Description = "Fiber length expressed in 100ths of an inch.";
            fiberLength.Value = ndbRecord.FiberLength;
            fiberLength.ValueType = OMCodeComponentValueTypeEnum.String;
            fiberLength.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(fiberLength);

            ObsCodeComponent lengthUniformity = new ObsCodeComponent();
            lengthUniformity.ComponentCode = "A_YLD_USDA_1GOSG_LENGTH_UNIFORMITY_INDEX";
            lengthUniformity.ComponentType = "OBSERVED_PROPERTY";
            lengthUniformity.Selector = "A_LENGTH_UNIFORMITY_INDEX";
            lengthUniformity.Description = "The ratio between the mean length and the upperhalf mean length of the fibers, expressed as a percentage.";
            lengthUniformity.Value = ndbRecord.LengthUniformity;
            lengthUniformity.ValueType = OMCodeComponentValueTypeEnum.String;
            lengthUniformity.ValueUoMCode = "";
            obsCollection.CodeComponents.Add(lengthUniformity);

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

            ContextItem remarks = new ContextItem();
            remarks.Code = "US_USDA_1GOSG_REMARKS";
            remarks.Value = ndbRecord.Remarks;
            record.NestedItems.Add(remarks);

            ContextItem recordType = new ContextItem();
            recordType.Code = "US_USDA_1GOSG_RECORD_TYPE";
            recordType.Value = ndbRecord.RecordType;
            record.NestedItems.Add(recordType);

            ContextItem recordStatus = new ContextItem();
            recordStatus.Code = "US_USDA_1GOSG_RECORD_STATUS";
            recordStatus.Value = ndbRecord.RecordStatus;
            record.NestedItems.Add(recordStatus);

            ContextItem CCCLoan = new ContextItem();
            CCCLoan.Code = "US_USDA_1GOSG_LOAN_PREMIUM";
            CCCLoan.Value = ndbRecord.CCCLoan;
            record.NestedItems.Add(CCCLoan);

            load.ContextItems.Add(record);

            return load;
        }
    }
}