using AgGateway.ADAPT.ApplicationDataModel.ADM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace CottonClassingPlugin
{
    public class Plugin : IPlugin
    {
        string IPlugin.Name => "Cotton Classing DB File Plugin";
        string IPlugin.Version => "0.1";
        string IPlugin.Owner => "AgGateway";
        public IList<IError> Errors => throw new NotImplementedException();

        /// <summary>
        /// ATTENTION!: This method is for testing locally within your debugger, and is called from the ExampleDataImporter Main method
        /// </summary>
        /// <returns></returns>
        public IList<ApplicationDataModel> RunPlugin()
        {
            //A plugin publisher can choose to create one or multiple application data models as appropriate for the data
            IList<ApplicationDataModel> admList = new List<ApplicationDataModel>();
            ApplicationDataModel adm = new ApplicationDataModel();
            
            string dataPath = @"D:\Odrive\OneDrive For Business - OAGi\AgGateway\ADAPT\Cotton Classing Database File Import Plugin\Cotton Classing Database File Import Plugin\PublisherDataModel\ExampleData";
            //Find any data files in the defined path
            string[] myDataFiles = Directory.GetFiles(dataPath, "USDA-Cotton Flat File.txt", SearchOption.AllDirectories);
            if (myDataFiles.Any())
            {
                foreach (string myDataFile in myDataFiles)
                {
                    //Import each file
                    PublisherDataModel.Data data = new PublisherDataModel.Data();
                    data.NDBData = PublisherDataModel.FlatFileHelper.ConvertFlatFileToModel(File.ReadAllText(myDataFile, System.Text.Encoding.Default));

                    #region JSON code
                    //string myJson = PublisherDataModel.FlatFileHelper.ConvertFlatFileToJSON(File.ReadAllText(myDataFile, System.Text.Encoding.Default));
                    //var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJson);
                    //data.NDBData = JsonConvert.DeserializeObject<PublisherDataModel.Data>(jObject.ToString());
                    #endregion

                    DataMappers.DataMapper.MapData(data, adm);
                }

                admList.Add(adm);
            }

            return admList;
        }

        IList<ApplicationDataModel> IPlugin.Import(string dataPath, Properties properties)
        {
            IList<ApplicationDataModel> models = new List<ApplicationDataModel>();

            //Find any data files in the defined path
            string[] myDataFiles = Directory.GetFiles(dataPath, "USDA-Cotton Flat File.txt", SearchOption.AllDirectories);
            if (myDataFiles.Any())
            {
                //A plugin publisher can choose to create one or multiple application data models as appropriate for the data
                ApplicationDataModel adm = new ApplicationDataModel();
                adm.Catalog = new Catalog() { Description = $"ADAPT data transformation of Publisher data {DateTime.Now.ToShortDateString()} {dataPath}" };
                //var loads = new List<AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load>();
                models.Add(adm);

                foreach (string myDataFile in myDataFiles)
                {
                    //Import each file
                    PublisherDataModel.Data data = new PublisherDataModel.Data();
                    data.NDBData = PublisherDataModel.FlatFileHelper.ConvertFlatFileToModel(File.ReadAllText(myDataFile, System.Text.Encoding.Default));
                    DataMappers.DataMapper.MapData(data, adm);
                }
            }

            return models;           
        }

        /// <summary>
        /// Export works just like import, except the Mappers should work in the reverse direction
        /// </summary>
        /// <param name="dataModel">The ADAPT adm to export to the plugin's format</param>
        /// <param name="exportPath">Path to publish to</param>
        /// <param name="properties">Any proprietary values the user may pass in customizing the export</param>
        void IPlugin.Export(ApplicationDataModel dataModel, string exportPath, Properties properties)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// GetProperties is an optional feature to return 
        /// basic key/value information about a data set without
        /// completing the complete transformation
        /// </summary>
        /// <param name="dataPath"></param>
        /// <returns></returns>
        Properties IPlugin.GetProperties(string dataPath)
        {
            
            throw new NotImplementedException();
        }


        /// <summary>
        ///Initialize is an optional feature if a publisher wishes
        ///to secure use of the plugin with specific arguments  
        ///or otherwise customize the behavior with a particular set of parameters
        /// <param name="args"></param>
        void IPlugin.Initialize(string args)
        {

        }

        /// <summary>
        /// Determines whether the folder contains data that this plugin can import
        /// </summary>
        /// <param name="dataPath"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        bool IPlugin.IsDataCardSupported(string dataPath, Properties properties)
        {
            //In this simple example, we are simply looking for the myjson extension to identify data in our format
            if (Directory.GetFiles(dataPath, "*.txt", SearchOption.AllDirectories).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Examines the contents of a data file for formatting errors
        /// </summary>
        /// <param name="dataPath"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        IList<IError> IPlugin.ValidateDataOnCard(string dataPath, Properties properties)
        {
            throw new NotImplementedException();
        }
    }
}
