using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using dummy.Library.Entity.Models;

namespace dummy.Library.DataProvider
{
    public class GetAllPerson
    {
        public async Task<IEnumerable<TestModel>> Get() =>
            await new SQLGetListAsync().ExecuteAsEnumerableAsync<TestModel>("user_get_all_user");
    }
}
