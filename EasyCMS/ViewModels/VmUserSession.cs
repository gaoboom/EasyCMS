using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.ViewModels
{
    /// <summary>
    /// 用户登录后的Session Model
    /// 根据业务需求进行调整
    /// <remarks>
    /// Created at 2016.12.16 by Ben
    /// </remarks>
    /// </summary>
    public class VmUserSession
    {
        public int UserID { get; set; }

        public string Account { get; set; }

        public string TelNum { get; set; }

        public string NickName { get; set; }
    }
}