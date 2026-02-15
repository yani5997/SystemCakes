using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataAccess.Log
{
    public static class LogErp
    {
        private const string FilePath = "log.txt";

        public static void EscribirDisco(Error error)
        {
            using var fileStream = new FileStream(FilePath, FileMode.Append);
            using var writter = new StreamWriter(fileStream);
            writter.WriteLine($"{DateTime.Now.ToString()} - {error.Message} - {error.Operation} - {error.Code} - {error.Objeto}");
        }

        public static void EscribirBaseDatos(Error error)
        {

        }
    }
}
