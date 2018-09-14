using FactoryVsStrategy.Data;
using System.Collections.Generic;

namespace FactoryVsStrategy.Strategies
{
    public class ScrubProduct
    {
        private List<DataModel> _dataCollection;
        private SortStrategy _sortStrategy;

        public ScrubProduct(SortStrategy sortStategy, List<DataModel> dataCollection)
        {
            _sortStrategy = sortStategy;
            _dataCollection = dataCollection;
        }

        public void Sort()
        {
            _sortStrategy.SortProducts(_dataCollection);
        }

    }
}
