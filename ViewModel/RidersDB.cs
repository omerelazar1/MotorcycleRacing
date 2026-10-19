using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class RidersDB:BaseDB
    {
        public RidersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Riders";
            RidersList RidersLst = new RidersList(base.Select());
            return RidersLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Riders();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Riders c = entity as Riders;
            c.StartYear = DateTime.Parse(reader["startYear"].ToString());
            c.IsActive = bool.Parse(reader["isActive"].ToString());
            base.CreateModel(entity);
            return c;
        }
        public static Riders SelectById(int id)
        {
            RidersDB db = new RidersDB();
            RidersList list = db.SelectAll();
            Riders g = list.Find(item => item.Id == id);
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
