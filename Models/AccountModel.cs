using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext  context = null; 

        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login (string userName, string passWord)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", passWord)
            };
            var res = context.Database.SqlQuery<bool>("SP_Account_Login @UserName, @Password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}
