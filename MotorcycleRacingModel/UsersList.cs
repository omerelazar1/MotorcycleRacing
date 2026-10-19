using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class UsersList:List<Users>
    {
        public UsersList() { }
        public UsersList(IEnumerable<Users> list) : base(list) { }
        public UsersList(IEnumerable<BaseEntity> list) : base(list.Cast<Users>().ToList()) { }
    }
}
