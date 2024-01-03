using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class LoginRepo : Repo, IRepo<Login, int>
    {
        public bool Add(Login obj)
        {
            db.Logins.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var dbuser = Get(id);
            db.Logins.Remove(dbuser);
            return db.SaveChanges() > 0;
        }

        public List<Login> Get()
        {
            return db.Logins.ToList();
        }

        public Login Get(int id)
        {
            return db.Logins.Find(id);
        }

        public Login Get(string uname)
        {
            return db.Logins.FirstOrDefault(u => u.Uname.Equals(uname));
        }

        public Login Get(int id, string id2)
        {
            throw new NotImplementedException();
        }

        public Login GetbyFK(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login obj)
        {
            var dbuser = Get(obj.Id);
            db.Entry(dbuser).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
