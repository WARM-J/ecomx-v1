using order.Library.DataProvider;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DGetOrderCount
    {
        readonly GetOrderTableCount _getOrderCount = new GetOrderTableCount();
        public async Task<int> Get()
        {
            return await _getOrderCount.Get();
        }
    }
}
