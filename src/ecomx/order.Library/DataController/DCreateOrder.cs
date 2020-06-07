using order.Library.DataProvider;
using order.Library.Entity.Model;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace order.Library.DataController
{
    public class DCreateOrder
    {
        readonly CreateOrder _createOrder = new CreateOrder();
        public async Task Create(OrderModel model, string userId, string orderNumber, decimal total)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@FullName",model.FullName),
                new SQLParam("@OrderNumber",orderNumber),
                new SQLParam("@PhoneNumber",model.PhoneNumber),
                new SQLParam("@OrderDate",DateTime.Now),
                new SQLParam("@UserId",userId),
                new SQLParam("@Address",model.Address),
                new SQLParam("@City",model.City),
                new SQLParam("@DeliveryInstruction",model.DeliveryInstruction),
                new SQLParam("@Total",total),
            };
            await _createOrder.Create(sQLParams);
        }
    }
}
