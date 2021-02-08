using System;

namespace Design_a_database_connection
{
    public abstract class DBConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }


        public DBConnection(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                throw new ArgumentNullException("Connection is empty");
            }

            this.ConnectionString = connection;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
