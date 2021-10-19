using System;
using System.Collections.Generic;
using System.Text;

namespace CottonClassingPlugin.PublisherDataModel
{
    public class NDBData : BaseObject
    {
        public List<NDBRecord> NDBRecords { get; set; }

        public NDBData()
        {
            NDBRecords = new List<NDBRecord>();
        }
    }

    //public class NDBRecord : BaseObject
    public class NDBRecord
    {
        public string GINCode { get; set; }
        public string GINBale { get; set; }
        public string DateClassed { get; set; }
        public string ReportingBasis { get; set; }
        public string ModuleTrailerNumber { get; set; }
        public string NumberOfBales { get; set; }
        public string OfficialColorGrade { get; set; }
        public string StapleLength { get; set; }
        public string Micronaire { get; set; }
        public string Strength { get; set; }
        public string LeafGrade { get; set; }
        public string ExtraneousMatter { get; set; }
        public string Remarks { get; set; }
        public string HVIColorGrade { get; set; }
        public string ColorQuadrant { get; set; }
        public string RD { get; set; }
        public string B { get; set; }
        public string NonLintContent { get; set; }
        public string FiberLength { get; set; }
        public string LengthUniformity { get; set; }
        public string UplandOrPima { get; set; }
        public string RecordType { get; set; }
        public string RecordStatus { get; set; }
        public string CCCLoan { get; set; }
    }

    public class FlatFileHelper
    {
        public static string ConvertFlatFileToJSON(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"NDBData\": { \"NDBRecords\": [");

            string[] result = input.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i <= result.GetUpperBound(0); i++)
            {
                sb.Append("{");

                sb.Append("\"GINCode\": \"" + result[i].Substring(0, 5) + "\",");
                sb.Append("\"GINBale\": \"" + result[i].Substring(5, 7) + "\",");
                sb.Append("\"DateClassed\": \"" + result[i].Substring(12, 8) + "\",");
                sb.Append("\"ReportingBasis\": \"" + result[i].Substring(20, 1) + "\",");
                sb.Append("\"ModuleTrailerNumber\": \"" + result[i].Substring(21, 5) + "\",");
                sb.Append("\"NumberOfBales\": \"" + result[i].Substring(26, 2) + "\",");
                sb.Append("\"OfficialColorGrade\": \"" + result[i].Substring(28, 2) + "\",");
                sb.Append("\"StapleLength\": \"" + result[i].Substring(30, 2) + "\",");
                sb.Append("\"Micronaire\": \"" + result[i].Substring(32, 2) + "\",");
                sb.Append("\"Strength\": \"" + result[i].Substring(34, 3) + "\",");
                sb.Append("\"LeafGrade\": \"" + result[i].Substring(37, 1) + "\",");
                sb.Append("\"ExtraneousMatter\": \"" + result[i].Substring(38, 2) + "\",");
                sb.Append("\"Remarks\": \"" + result[i].Substring(40, 2) + "\",");
                sb.Append("\"HVIColorGrade\": \"" + result[i].Substring(42, 2) + "\",");
                sb.Append("\"ColorQuadrant\": \"" + result[i].Substring(44, 1) + "\",");
                sb.Append("\"RD\": \"" + result[i].Substring(45, 3) + "\",");
                sb.Append("\"B\": \"" + result[i].Substring(48, 3) + "\",");
                sb.Append("\"NonLintContent\": \"" + result[i].Substring(51, 2) + "\",");
                sb.Append("\"FiberLength\": \"" + result[i].Substring(53, 3) + "\",");
                sb.Append("\"LengthUniformity\": \"" + result[i].Substring(56, 3) + "\",");
                sb.Append("\"UplandOrPima\": \"" + result[i].Substring(59, 1) + "\",");
                sb.Append("\"RecordType\": \"" + result[i].Substring(60, 1) + "\",");
                sb.Append("\"RecordStatus\": \"" + result[i].Substring(61, 1) + "\",");
                sb.Append("\"CCCLoan\": \"" + result[i].Substring(62, 5) + "\"");

                sb.Append("}");
                if (i < result.GetUpperBound(0))
                {
                    sb.Append(",");
                }
            }

            sb.Append("]}}");

            return sb.ToString();
        }

        public static NDBData ConvertFlatFileToModel(string input)
        {
            NDBData ndbData = new NDBData();
            NDBRecord ndbRecord = new NDBRecord();

            string[] result = input.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i <= result.GetUpperBound(0); i++)
            {
                ndbRecord.GINCode = result[i].Substring(0, 5);
                ndbRecord.GINBale = result[i].Substring(5, 7);
                ndbRecord.DateClassed = result[i].Substring(12, 8);
                ndbRecord.ReportingBasis = result[i].Substring(20, 1);
                ndbRecord.ModuleTrailerNumber = result[i].Substring(21, 5);
                ndbRecord.NumberOfBales = result[i].Substring(26, 2);
                ndbRecord.OfficialColorGrade = result[i].Substring(28, 2);
                ndbRecord.StapleLength = result[i].Substring(30, 2);
                ndbRecord.Micronaire = (Convert.ToDecimal(result[i].Substring(32, 2)) / 10).ToString();
                ndbRecord.Strength = (Convert.ToDecimal(result[i].Substring(34, 3)) / 10).ToString();
                ndbRecord.LeafGrade = result[i].Substring(37, 1);
                ndbRecord.ExtraneousMatter = result[i].Substring(38, 2);
                ndbRecord.Remarks = result[i].Substring(40, 2);
                ndbRecord.HVIColorGrade = result[i].Substring(42, 2);
                ndbRecord.ColorQuadrant = result[i].Substring(44, 1);
                ndbRecord.RD = (Convert.ToDecimal(result[i].Substring(45, 3)) / 10).ToString();
                ndbRecord.B = (Convert.ToDecimal(result[i].Substring(48, 3)) / 10).ToString();
                ndbRecord.NonLintContent = result[i].Substring(51, 2);
                ndbRecord.FiberLength = (Convert.ToDecimal(result[i].Substring(53, 3)) / 100).ToString();
                ndbRecord.LengthUniformity = (Convert.ToDecimal(result[i].Substring(56, 3)) / 10).ToString();
                ndbRecord.UplandOrPima = result[i].Substring(59, 1);
                ndbRecord.RecordType = result[i].Substring(60, 1);
                ndbRecord.RecordStatus = result[i].Substring(61, 1);
                ndbRecord.CCCLoan = result[i].Substring(62, 5);

                ndbData.NDBRecords.Add(ndbRecord);
            }

            return ndbData;
        }
    }
}