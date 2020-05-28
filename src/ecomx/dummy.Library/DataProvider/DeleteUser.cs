using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;


namespace dummy.Library.DataProvider
{
    public class DeleteUser
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("user_delete_user_by_id", sQLParams);
    }
}
