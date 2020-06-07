using order.Library.DataProvider;
using order.Library.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DGetAllOrder
    {
        readonly GetAllOrder _getAllOrder = new GetAllOrder();
        public async Task<IEnumerable<OrderModel>> GetAllOrder()
        {
            return await _getAllOrder.Get();
        }
    }
}
