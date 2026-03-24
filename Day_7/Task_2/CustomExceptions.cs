using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class SqlException : Exception
    {
        public SqlException(string message) : base(message) { }
    }

    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}

