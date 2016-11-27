using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModel;
using PetaPoco;

namespace BLL.UserBLL
{
    public class UserCommonFunc
    {
        public Response UserLogin(User u)
        {
            Response r = new Response();
            Database db = new Database("EasyCMSSql");
            User userCheck = db.Single<User>("where Account=@0 and Password=@1",u.Account,u.Password);
            if(userCheck!=null)
            {
                r.Code = 1;
                r.Message = "验证成功";
                r.ResObj = userCheck;
            }
            else
            {
                r.Code = 0;
                r.Message = "账户名或密码错误";
                r.ResObj = null;
            }
            return r;
        }
    }
}
