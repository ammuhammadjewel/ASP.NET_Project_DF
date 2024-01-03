using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<UsersDetail, int> UserDetailDataAccess()
        {
            return new UserDetailsRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new UserDetailsRepo();
        }

        public static ITokenRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }

        public static IRepo<Login, int> LoginDataAccess()
        {
            return new LoginRepo();
        }





 




        public static IRepo<AcademicInfo, int> UserAcademicInfoDataAccess()
        {
            return new AcademicInfoRepo();
        }



        public static IRepo<Apply, int> JobApplyDataAccess()
        {
            return new ApplicationsRepo();
        }

    }
}
