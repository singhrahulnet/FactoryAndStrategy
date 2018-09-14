using FactoryVsStrategy.Data;
using System.Collections.Generic;

namespace FactoryVsStrategy.Strategies
{
    public class SortStrategyByID : SortStrategy
    {
        public override void SortProducts(List<DataModel> dataCollection)
        {
            dataCollection.Sort((x, y) => x.Id.CompareTo(y.Id));
        }
    }
}
