using System;

namespace Design_a_database_connection
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string connection)
         : base(connection) {}



        public override void Open()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SqlConnection is open.");
            Console.ResetColor();
        }


        public override void Close()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SqlConnection is close.");
            Console.ResetColor();
        }
    }
}
