using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using dummy.Library.Entity.Models;
using SQLHelper;

namespace dummy.Library.DataProvider
{
    public class GetUser
    {
        public async Task<TestModel> Get(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<TestModel>("user_get_user_by_id", sQLParams);
        }
    }
}
