namespace CodeShop.UI;

public class DatabaseEventArgs : EventArgs
{
    public Database Database { get; }

    public DatabaseEventArgs(Database database)
    {
        Database = database;
    }
}