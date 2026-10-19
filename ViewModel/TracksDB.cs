using MotorcycleRacingModel;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TracksDB : BaseDB
    {
        public TracksList SelectAll()
        {
            command .CommandText = $"SELECT * FROM Tracks";
            TracksList TracksLst = new TracksList(base.Select());
            return TracksLst;
        }

        public override BaseEntity NewEntity()
        {
            return new Tracks();
            
        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Tracks c = entity as Tracks;
            c.TrackDescription = reader["trackDescription"].ToString();
            base.CreateModel(entity);
            return c;
        }
        static private TracksList list = new TracksList();

        public static Tracks SelectById(int id)
        {
            TracksDB db = new TracksDB();
            list = db.SelectAll();
            Tracks g = list.Find(item => item.Id==id);
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
