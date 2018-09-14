using FactoryVsStrategy.Data;
using System;
using System.Collections.Generic;

namespace FactoryVsStrategy.Factory
{
    public class FlatFileOutput : IFileOutput
    {
        public void GenerateOutput(List<DataModel> dataCollection, string outputPath)
        {
            //Add code here to output the file in txt format
            Console.WriteLine("*****THIS IS FLAT FORMAT*****");
            foreach (var item in dataCollection)
            {
                Console.WriteLine("ID: {0}, Display Order: {1}, Name: {2}, Description: {3}", item.Id, item.DisplayOrder, item.Name, item.Description);

            }
        }
    }
}
