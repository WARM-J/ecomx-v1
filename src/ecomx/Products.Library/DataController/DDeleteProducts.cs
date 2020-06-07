using Products.Library.DataProvider;
using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Library.DataController
{
    public class DDeleteProducts
    {
        readonly DeleteProducts _deleteProduct = new DeleteProducts();
        public async Task Delete(int productID)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductID",productID)
            };
            await _deleteProduct.Delete(sQLParams);
        }
    }
}
