using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class UsersDB:BaseDB
    {
        public UsersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Users";
            UsersList UsersLst = new UsersList(base.Select());
            return UsersLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Users();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Users c = entity as Users;
            c.Email = reader["email"].ToString();
            c.FirstName = reader["firstName"].ToString();
            c.LastName = reader["lastName"].ToString();
            c.IsAdmin = bool.Parse(reader["isAdmin"].ToString());
            c.Pass = reader["pass"].ToString();
            c.Phone = int.Parse(reader["phone"].ToString());
            base.CreateModel(entity);
            return c;
        }
        public static Users SelectById(int id)
        {
            UsersDB db = new UsersDB();
            UsersList list = db.SelectAll();
            Users g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
}
