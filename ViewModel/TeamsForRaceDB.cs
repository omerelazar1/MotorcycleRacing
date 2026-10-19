using MotorcycleRacingModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TeamsForRaceDB:BaseDB
    {
        public TeamsForRaceList SelectAll()
        {
            command.CommandText = $"SELECT * FROM TeamsForRace";
            TeamsForRaceList TeamsForRaceLst = new TeamsForRaceList(base.Select());
            return TeamsForRaceLst;
        }
        public override BaseEntity NewEntity()
        {
            return new TeamsForRace();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            TeamsForRace c = entity as TeamsForRace;
            c.TeamID = TeamsDB.SelectById(int.Parse(reader["teamID"].ToString()));
            c.RaceID = RacesDB.SelectById(int.Parse(reader["raceID"].ToString()));
            base.CreateModel(entity);
            return c;
        }
        public static TeamsForRace SelectById(int id)
        {
            TeamsForRaceDB db = new TeamsForRaceDB();
            TeamsForRaceList list = db.SelectAll();
            TeamsForRace g = list.Find(item => item.Id == id);
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
