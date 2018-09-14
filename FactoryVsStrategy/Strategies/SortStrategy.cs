using FactoryVsStrategy.Data;
using System.Collections.Generic;

namespace FactoryVsStrategy.Strategies
{
    public abstract class SortStrategy
    {
        public abstract void SortProducts(List<DataModel> dataCollection);
    }
}
