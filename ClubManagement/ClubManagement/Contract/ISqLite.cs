using SQLite;

namespace ClubManagement.Business
{
    public interface ISqLite
    {
        SQLiteConnection GetConnection(string sqliteFilename);
    }
}
