using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H.DataAccess.Enums;

namespace H.DataAccess.Log
{
    public class Error : IError
    {
        public string Level { get; set; }
        public string Message { get; set; }
        public string Origin { get; set; }
        public string Severity { get; set; }
        public TiposError Code { get; set; }
        public Exception Exception { get; set; }
        public string Project { get; set; }
        public string Operation { get; set; }
        public string Objeto { get; set; }
    }
}
