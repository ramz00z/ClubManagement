using ClubManagement.Business;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
public class SQLite_Android : ISqLite
{
    public SQLite_Android() { }
    public SQLite.SQLiteConnection GetConnection(string sqliteFilename)
    {
        string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
        var path = Path.Combine(documentsPath, sqliteFilename);
        // Create the connection
        var conn = new SQLite.SQLiteConnection(path);
        // Return the database connection
        return conn;
    }
}