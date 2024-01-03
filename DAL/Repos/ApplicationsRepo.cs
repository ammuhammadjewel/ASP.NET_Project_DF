using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ApplicationsRepo : Repo, IRepo<Apply, int>
    {
        public bool Add(Apply obj)
        {
            db.Applies.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var jap = Get(id);
            db.Applies.Remove(jap);
            return db.SaveChanges() > 0;
        }

        public List<Apply> Get()
        {
            return db.Applies.ToList();
        }

        public Apply Get(int id)
        {
            return db.Applies.Find(id);
        }

        public Apply Get(string id)
        {
            throw new NotImplementedException();
        }

        public Apply Get(int id, string id2)
        {
            throw new NotImplementedException();
        }

        /*public Apply Get(int id, string id2)
        {
           
        }*/

        public Apply GetbyFK(int id)
        {
            return db.Applies.FirstOrDefault(t => t.FK_Nid == id);
        }

        public bool Update(Apply obj)
        {
            var acc = Get(obj.Id);
            db.Entry(acc).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
