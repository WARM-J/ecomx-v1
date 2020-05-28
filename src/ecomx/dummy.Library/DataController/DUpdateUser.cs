using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using dummy.Library.Entity.Models;
using dummy.Library.DataProvider;
using System.Threading.Tasks;

namespace dummy.Library.DataController
{
    public class DUpdateUser
    {
        readonly UpdateUser _updateUser = new UpdateUser();
        public async Task Update(TestModel user)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Id",user.Id),
                new SQLParam("@Name",user.Name),
                new SQLParam("@Age",user.Age),
                new SQLParam("@Address",user.Address)
            };
            await _updateUser.Update(sQLParams);
        }

    }
}
