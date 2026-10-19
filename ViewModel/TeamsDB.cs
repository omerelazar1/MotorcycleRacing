using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class TeamsDB:BaseDB
    {
        public TeamsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Teams";
            TeamsList TeamsLst = new TeamsList(base.Select());
            return TeamsLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Teams();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Teams c = entity as Teams;
            c.TeamName = reader["teamName"].ToString();
            c.EstablishDate = DateTime.Parse(reader["establishDate"].ToString());
            base.CreateModel(entity);
            return c;
        }
        public static Teams SelectById(int id)
        {
            TeamsDB db = new TeamsDB();
            TeamsList list = db.SelectAll();
            Teams g = list.Find(item => item.Id == id);
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
