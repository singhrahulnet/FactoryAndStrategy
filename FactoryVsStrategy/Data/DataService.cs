using System;
using System.Collections.Generic;

namespace FactoryVsStrategy.Data
{
    public class DataService
    {
        private List<DataModel> _dataModelCollection;
        public List<DataModel> GetData()
        {
            _dataModelCollection = new List<DataModel>();
            Random random = new Random(5);

            for (int i = 1; i <= 5; i++)
            {
                _dataModelCollection.Add(new DataModel
                {
                    Id = random.Next(20),
                    Name = random.Next(20) + " Product",
                    Description = random.Next(20) + " Description",    
                    DisplayOrder = random.Next(20)
                });
            }

            return _dataModelCollection;
        }
    }
}