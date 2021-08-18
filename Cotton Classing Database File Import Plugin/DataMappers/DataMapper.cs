using AgGateway.ADAPT.ApplicationDataModel.ADM;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Documents;
using CottonClassingPlugin.PublisherDataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CottonClassingPlugin.DataMappers
{
    public static class DataMapper
    {
        public static void MapData(Data myDataModel, ApplicationDataModel adm)
        {
            //Create an ADM Documents object
            Documents docs = new Documents();
            adm.Documents = docs;
            
            //Create a new observation object for our Documents object
            Observations observations = new Observations();
            var _observations = new List<Observations>();
            adm.Documents.Observations = _observations;
            
            //Create an ObsDataSet for our Documents object
            ObsDataset obsDataset = new ObsDataset();

            //Create an ADAPT container and load list object
            ContextItem parentContextItem = new ContextItem();
            var loads = new List<AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load>();
            var myOobsCollections = new List<AgGateway.ADAPT.ApplicationDataModel.Documents.ObsCollection>();
            var obs = new List<AgGateway.ADAPT.ApplicationDataModel.Documents.Obs>();

            //Import the NDB Records
            foreach (NDBRecord ndb in myDataModel.NDBData.NDBRecords)
            {
                //IMPORTANT! Each one of these iterations are for a unique load
                AgGateway.ADAPT.ApplicationDataModel.Documents.ObsCollection obsCollection = new AgGateway.ADAPT.ApplicationDataModel.Documents.ObsCollection();
                AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load load = new AgGateway.ADAPT.ApplicationDataModel.LoggedData.Load();

                //Determine the load type (Bale or Module)
                //***********The ADAPT team is adding CottonTrailer as an additional enum value.
                if (ndb.ReportingBasis == "0")
                {
                    load.LoadType = AgGateway.ADAPT.ApplicationDataModel.LoggedData.LoadTypeEnum.Bale;
                }
                else
                {
                    load.LoadType = AgGateway.ADAPT.ApplicationDataModel.LoggedData.LoadTypeEnum.Module;
                }

                //We create a new load for each unique record
                load = NDBRecordMapper.MapNDBRecord(ndb, load);

                //We create a new Observation Collection for each unique load
                obsCollection = NDBRecordMapper.MapNDBRecordObsCollection(ndb, obs, load.Id.ReferenceId, obsCollection, obsDataset, adm);
                myOobsCollections.Add(obsCollection);
                obsDataset.ObsCollectionIds.Add(obsCollection.Id.ReferenceId);
                load.ObsCollectionId = obsCollection.Id.ReferenceId;

                loads.Add(load);
            }

            var _obsDataSets = new List<ObsDataset>();
            _obsDataSets.Add(obsDataset);
            adm.Documents.ObsDatasets = _obsDataSets;
            adm.Documents.ObsCollections = myOobsCollections;
            adm.Documents.Obs = obs;

            adm.Documents.Loads = loads;
        }

        public static UniqueId GetNativeID(BaseObject obj)
        {
            UniqueId id = new UniqueId();
            id.Id = obj.ID.ToString();
            id.IdType = IdTypeEnum.UUID;
            id.Source = "http://PublisherName.example";
            id.SourceType = IdSourceTypeEnum.URI;
            return id;
        }
    }
}
