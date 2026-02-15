using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Log
{
    public interface IError
    {
        //public string Error { get; set; }
        public string Origin { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public string Severity { get; set; }

    }
}
