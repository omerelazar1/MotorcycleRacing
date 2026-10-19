using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class TeamMembersDB:BaseDB
    {
        public TeamMembersList SelectAll()
        {
            command.CommandText = $"SELECT * FROM TeamMembers";
            TeamMembersList TeamMembersLst = new TeamMembersList(base.Select());
            return TeamMembersLst;
        }
        public override BaseEntity NewEntity()
        {
            return new TeamMembers();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            TeamMembers c = entity as TeamMembers;
            c.TeamID = TeamsDB.SelectById(int.Parse(reader["TeamID"].ToString()));
            c.RiderID = RidersDB.SelectById(int.Parse(reader["RiderID"].ToString()));
            base.CreateModel(entity);
            return c;
        }
        public static TeamMembers SelectById(int id)
        {
            TeamMembersDB db = new TeamMembersDB();
            TeamMembersList list = db.SelectAll();
            TeamMembers g = list.Find(item => item.Id == id);
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
