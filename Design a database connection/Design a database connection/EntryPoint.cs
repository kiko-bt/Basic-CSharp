using System;

namespace Design_a_database_connection
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            DbCommand command = new DbCommand(new SqlConnection("to sql server"), "select * from Customer");
            DbCommand command2 = new DbCommand(new OracleConnection("to oracle"), "select * from Product");
            command.Execute();
            command2.Execute();














            Console.ReadLine();
        }
    }
}
