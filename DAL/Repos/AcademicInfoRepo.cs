using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class AcademicInfoRepo : Repo, IRepo<AcademicInfo, int>
    {
        public bool Add(AcademicInfo obj)
        {
            db.AcademicInfos.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ui = Get(id);
            db.AcademicInfos.Remove(ui);
            return db.SaveChanges() > 0;
        }

        public List<AcademicInfo> Get()
        {
            return db.AcademicInfos.ToList();
        }

        public AcademicInfo Get(int id)
        {
            return db.AcademicInfos.Find(id);
        }

        public AcademicInfo Get(string id)
        {
            throw new NotImplementedException();
        }

        public AcademicInfo Get(int id, string id2)
        {
            throw new NotImplementedException();
        }

        public AcademicInfo GetbyFK(int id)
        {
            return db.AcademicInfos.FirstOrDefault(t => t.FK_NID == id);
        }

        public bool Update(AcademicInfo obj)
        {
            var rs = Get(obj.RId);
            db.Entry(rs).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
