using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using dummy.Library.Entity.Models;
using SQLHelper;
using dummy.Library.DataProvider;

namespace dummy.Library.DataController
{
    public class DGetUser
    {
        readonly GetUser _getUser = new GetUser();
        public async Task<TestModel> UserById(int id)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@Id",id)
            };
            return await _getUser.Get(sQLParams);
        
        }
   
    }
}
