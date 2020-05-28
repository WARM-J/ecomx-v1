using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using dummy.Library.Entity.Models;
using dummy.Library.DataProvider;
using System.Threading.Tasks;

namespace dummy.Library.DataController
{
    public class DDleteUser
    {
        readonly DeleteUser _deleteUser = new DeleteUser();
        public async Task Delete(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Id",id)
            };
            await _deleteUser.Delete(sQLParams);
        }
    }
}
