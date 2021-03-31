using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DataAccessLayer
{
    public class UserDal
    {
        DbCon db = new DbCon();
        public bool addUser(User U)
        {
            string qry = "INSERT INTO users (NAME,EMAIL) VALUES ('"+U.NAME1+"', '"+U.EMAIL1+"')";
            return db.UDI(qry);
        }

        public bool deleteUser(User U)
        {
            string qry = "Delete from users where ID='" + U.ID1 + "'";
            return db.UDI(qry);
        }

        public bool updateUser(User U)
        {
            string qry = "UPDATE users SET NAME='" + U.NAME1 + "', EMAIL = '" + U.EMAIL1 + "' WHERE ID = '" + U.ID1 + "'";
            return db.UDI(qry);
        }

        public DataTable searchUser(User U)
        {
            string qry = "SELECT * FROM users WHERE ID = '" + U.ID1 + "'";
            return db.Search(qry);
        }

        public DataTable allUsers()
        {
            string qry = "SELECT * FROM users";
            return db.Search(qry);
        }
    }
}
