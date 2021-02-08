using System;

namespace Design_a_database_connection
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connection)
            :base(connection) {}


        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OracleConnection is open.");
            Console.ResetColor();
        }

        public override void Close()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OracleConnetion is close.");
            Console.ResetColor();
        }
    }
}
