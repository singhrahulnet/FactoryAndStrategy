using FactoryVsStrategy.Data;
using FactoryVsStrategy.Factory;
using FactoryVsStrategy.Strategies;
using System.Collections.Generic;

namespace FactoryVsStrategy
{
    public class ProductManager
    {
        public void PublishAll()
        {
            List<DataModel> dataCollection;
            ScrubProduct scrubProduct;

            //Call the service and get the data
            dataCollection = GetData();

            //Scrubbing the data using different strategies. Strategy Design Pattern.
            //Notice that the behaviour (strategy) of the class changes at runtime 
            scrubProduct = new ScrubProduct(new SortStrategyByID(), dataCollection);
            scrubProduct.Sort();

            //Publishing the data using different output options. Factory Pattern.
            //Notice that instantiation of correct class is deferred to FileOutputFactory
            PublishOutput(dataCollection, OutputFormat.EXCEL);

            //Reapting the operations to showcase a different sorting behaviour and a different output option
            scrubProduct = new ScrubProduct(new SortStrategyByDisplayOrder(), dataCollection);
            scrubProduct.Sort();
            PublishOutput(dataCollection, OutputFormat.FLAT);
        }

        private static List<DataModel> GetData()
        {
            DataService service = new DataService();

            List<DataModel> dataCollection = service.GetData();
            return dataCollection;
        }

        private static void PublishOutput(List<DataModel> dataCollection, OutputFormat format)
        {
            IFileOutput myFormat = FileOutputFactory.GetMyFormatter(format);
            myFormat.GenerateOutput(dataCollection, "");
        }

    }
}
