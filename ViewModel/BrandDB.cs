using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcycleRacingModel;

namespace ViewModel
{
    public class BrandDB:BaseDB
    {
        public BrandList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Brand";
            BrandList BrandLst = new BrandList(base.Select());
            return BrandLst;
        }
        public override BaseEntity NewEntity()
        {
            return new Brand();

        }
        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Brand c = entity as Brand;
            c.BrandName = reader["brandName"].ToString();
            c.BrandDescription = reader["Description"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public static Brand SelectById(int id)
        {
            BrandDB db = new BrandDB();
            BrandList list = db.SelectAll();
            Brand g = list.Find(item => item.Id == id);
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
            Brand b = entity as Brand;
            if (b != null)
            {
                string sqlStr = $"UPDATE Brand SET BrandName=@bName,Description=@bDescription WHERE ID=@id";

            }
        }
    }
}
