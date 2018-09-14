using FactoryVsStrategy.Data;
using System.Collections.Generic;

namespace FactoryVsStrategy.Strategies
{
    public class SortStrategyByDisplayOrder : SortStrategy
    {
        public override void SortProducts(List<DataModel> dataCollection)
        {
            dataCollection.Sort((x, y) => x.DisplayOrder.CompareTo(y.DisplayOrder));
        }
    }
}
