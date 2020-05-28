using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using dummy.Library.Entity.Models;
using System.Threading.Tasks;

namespace dummy.Library.DataProvider
{
    public class CreateUser
    {
        public async Task Create(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("user_create_user", sQLParams);
    }
}
