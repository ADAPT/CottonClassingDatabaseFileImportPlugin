using System;
using System.Collections.Generic;
using System.Text;

namespace CottonClassingPlugin.PublisherDataModel
{
    /// <summary>
    /// A top level data container for the publishers data.
    /// This classes in this folder represent an existing data model 
    /// that a publishing company may already have and wish to expose
    /// through the ADAPT Framework.
    /// </summary>
    public class Data
    {
        public NDBData NDBData { get; set; }

        public Data()
        {
            NDBData = new NDBData();
            Clients = new List<Client>();
        }
        public List<Client> Clients { get; set; }
    }

    public class Client : BaseObject
    {
        public Client() { Farms = new List<Farm>(); }
        public List<Farm> Farms { get; set; }
    }

    /// <summary>
    /// An organizational unit of the customer's operation
    /// </summary>
    public class Farm : BaseObject
    {
        public Farm() { Fields = new List<Field>(); }
        public List<Field> Fields { get; set; }
    }

    /// <summary>
    /// An individual field within the operation
    /// </summary>
    public class Field : BaseObject
    {
    }

    public class BaseObject
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
