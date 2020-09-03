using System;
using CottonClassingPlugin.PublisherDataModel.ExampleData;

namespace DataImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            CottonClassingPlugin.Plugin plugin = new CottonClassingPlugin.Plugin();
            plugin.RunPlugin();
        }
    }
}
