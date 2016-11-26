using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Response
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public object ResObj { get; set; }

        public Response()
        {
            Code = 0;
            Message = "";
            ResObj = null;
        }
    }
}
