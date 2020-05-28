using dummy.Library.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using dummy.Library.DataProvider;
namespace dummy.Library.DataController
{
    public class DGetAllUser
    {
        readonly GetAllPerson _getAllPerson = new GetAllPerson();
        public async Task<IEnumerable<TestModel>> AllUser()
        {
            return await _getAllPerson.Get();
        }
    }
}
