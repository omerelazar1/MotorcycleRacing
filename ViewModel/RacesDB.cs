using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class RacesDB:BaseDB
    {
        public static Races SelectById(int id)
        {
            RacesDB db = new RacesDB();
            RacesList list = db.SelectAll();
            Races g = list.Find(item => item.Id == id);
            return g;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Races r = entity as Races;
            r.RaceName = reader["raceName"].ToString();
            r.RaceDate = DateTime.Parse(reader["raceDate"].ToString());
            r.TrackID = TracksDB.SelectById(int.Parse(reader["trackID"].ToString()));
            base.CreateModel(entity);
            return r;
        }
        public RacesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Races";
            RacesList racesLst = new RacesList(base.Select());
            return racesLst;
        }

        public override BaseEntity NewEntity()
        {
            return new Races();
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
            Races r = entity as Races;
            if (r != null)
            {
                string sqlStr = $"UPDATE Races SET RaceName=@rRaceName, RaceDate=@rRaceDate, TrackID=@rTrackID WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@rRaceName", r.RaceName));
                command.Parameters.Add(new OleDbParameter("@rRaceDate",r.RaceDate));
                command.Parameters.Add(new OleDbParameter("@rTrackID",r.TrackID.Id));
                command.Parameters.Add(new OleDbParameter("@id",r.Id));
            }
            
        }
    }
}
