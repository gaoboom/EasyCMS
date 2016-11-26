using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModel
{
    public class User
    {
        public int UserID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }
        public int UserStatus { get; set; }
    }
}
