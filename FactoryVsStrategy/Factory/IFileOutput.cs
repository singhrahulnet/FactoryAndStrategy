using FactoryVsStrategy.Data;
using System.Collections.Generic;

namespace FactoryVsStrategy.Factory
{
    public interface IFileOutput
    {
        void GenerateOutput(List<DataModel> dataCollection, string outputPath);
    }
}
