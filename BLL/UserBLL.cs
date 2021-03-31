using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DataAccessLayer;

namespace BLL
{
    public class UserBLL
    {
        UserDal uDal = new UserDal();
        public bool adduserBll(User U)
        {
            return uDal.addUser(U);
        }
        public bool deleteUserbll(User U)
        {
            return uDal.deleteUser(U);
        }
        public bool updateUserbll(User U)
        {
            return uDal.updateUser(U);
        }
        public DataTable searchuserbll(User U)
            {
            return uDal.searchUser(U);
        }
        public DataTable allusersbll()
            {
            return uDal.allUsers();
        }

    }
}
