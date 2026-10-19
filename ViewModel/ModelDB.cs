using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class ModelDB:BaseDB
    {
        public ModelList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Model";
            ModelList ModelLst = new ModelList(base.Select());
            return ModelLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Model();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Model c = entity as Model;
            c.ModelDescription = reader["Description"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public static Model SelectById(int id)
        {
            ModelDB db = new ModelDB();
            ModelList list = db.SelectAll();
            Model g = list.Find(item => item.Id == id);
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
