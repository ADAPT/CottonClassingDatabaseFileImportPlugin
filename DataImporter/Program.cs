using System;
using CottonClassingPlugin.PublisherDataModel.ExampleData;

namespace DataImporter
{
    /// <summary>
    /// This program acts as a basic driver and test harness for developers to use when testing code changes in
    /// the USDA Cotton Classing Data File Import Plugin. This is a handy method for stepping through the plugin code
    /// before final testing is performed with the ADAPT Visualizer.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //First, create a new instance of the Cotton Classing plugin below
            CottonClassingPlugin.Plugin plugin = new CottonClassingPlugin.Plugin();

            //Set the path to your test file below
            string dataPath = @"C:\Projects\OAGi\ADAPT\USDA";

            //Call the RunPlugin method, passing in the path to your test data file
            plugin.RunPlugin();
        }
    }
}
