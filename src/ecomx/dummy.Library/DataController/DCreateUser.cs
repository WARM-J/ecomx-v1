using System;
using System.Collections.Generic;
using System.Text;
using dummy.Library.Entity.Models;
using SQLHelper;
using dummy.Library.DataProvider;
using System.Threading.Tasks;

namespace dummy.Library.DataController
{
    public class DCreateUser
    {
        readonly CreateUser _createUser = new CreateUser();
        public async Task Create(TestModel user)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Name",user.Name),
                new SQLParam("@Age",user.Age),
                new SQLParam("@Address",user.Address)
            };
            await _createUser.Create(sQLParams);
        }
    }
}
