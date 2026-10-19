using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class ResultsDB:BaseDB
    {
        public ResultsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Results";
            ResultsList ResultsLst = new ResultsList(base.Select());
            return ResultsLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Results();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Results c = entity as Results;
            c.First = reader["first"].ToString();
            c.Second = reader["second"].ToString();
            c.Third= reader["third"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public static Results SelectById(int id)
        {
            ResultsDB db = new ResultsDB();
            ResultsList list = db.SelectAll();
            Results g = list.Find(item => item.Id == id);
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
