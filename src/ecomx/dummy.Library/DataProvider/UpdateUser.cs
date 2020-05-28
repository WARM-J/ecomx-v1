using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using dummy.Library.Entity.Models;
using System.Threading.Tasks;

namespace dummy.Library.DataProvider
{
    public class UpdateUser
    {
        public async Task Update(List<SQLParam> sQLParams)
        {
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("user_update_user_by_id", sQLParams);
        }
    }
}
