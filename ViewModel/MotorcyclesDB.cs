using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class MotorcyclesDB : BaseDB
    {
        public MotorcyclesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Motorcycles";
            MotorcyclesList MotorcyclesLst = new MotorcyclesList(base.Select());
            return MotorcyclesLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Motorcycles();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Motorcycles c = entity as Motorcycles;
            c.NumberOfOwners = int.Parse(reader["NumberOfOwners"].ToString());
            c.Year = DateTime.Parse(reader["Year"].ToString());
            c.Brand = reader["Brand"].ToString();
            c.Model = reader["Model"].ToString();
            c.RiderID = RidersDB.SelectById(int.Parse(reader["RiderID"].ToString()));
            base.CreateModel(entity);
            return c;
        }
        public static Motorcycles SelectById(int id)
        {
            MotorcyclesDB db = new MotorcyclesDB();
            MotorcyclesList list = db.SelectAll();
            Motorcycles g = list.Find(item => item.Id == id);
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
            Motorcycles m = entity as Motorcycles;
            if (m != null)
            {
                string sqlStr = $"UPDATE Motorcycles SET RiderID=@mRiderID, Brand=@mBrand, Model=@mModel, Year=@mYear, NumberofOwners=@mNumberofOwners WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mRiderID", m.RiderID.Id));
            }
        }
    }
}
