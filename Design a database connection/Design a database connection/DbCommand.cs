using System;

namespace Design_a_database_connection
{
    public class DbCommand
    {
        public DBConnection Connection { get; set; }
        public string Instruction { get; set; }



        public DbCommand(DBConnection connection, string instruction)
        {
            if (connection == null || string.IsNullOrEmpty(instruction))
            {
                throw new ArgumentException("Connection cannot be empty!");
            }

            this.Connection = connection;
            this.Instruction = instruction;
        }
        

        public void Execute()
        {
            this.Connection.Open();
            Console.WriteLine($"Instruction: {Instruction}");
            this.Connection.Close();
        }
    }
}
