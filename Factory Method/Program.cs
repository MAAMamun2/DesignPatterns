using Factory_Method;

IDatabaseConnectionFactory factory;
//factory = new SQLDatabaseConnectionFactory();
factory = new OracleDatabaseConnectionFactory();
DatabaseClient client = new DatabaseClient(factory);
client.UseDatabase();
Console.ReadLine();
