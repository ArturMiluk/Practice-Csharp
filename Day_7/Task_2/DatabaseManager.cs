using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class DatabaseManager
    {
        private readonly DatabaseConnector _connector = new DatabaseConnector();

        public void Initialize(string config)
        {
            try
            {
                _connector.Connect(config);
            }
            catch (SqlException ex)
            {
                throw new DatabaseConnectionException("Не удалось инициализировать менеджер базы данных.", ex);
            }
        }
    }
}

