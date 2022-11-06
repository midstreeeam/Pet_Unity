using SQLite;
using System.Configuration;

public class DatabaseHandler
{

    private SQLiteConnection _db;

    public DatabaseHandler()
    {
        _db = new SQLiteConnection(ConfigurationManager.AppSettings["DBpath"]);
        TableInit();
    }

    private void TableInit()
    {
        _db.CreateTable<Users>();
        _db.CreateTable<Pets>();
        _db.CreateTable<Animations>();
        _db.CreateTable<History>();
    }

    public void AddUser(String user_name,  int pet_id, String email = null, String gender = null)
    {
        var user = new Users
        {
            UserName = user_name
            , PetId = pet_id
            ,Email = email
            ,Gender = gender
        };
        _db.Insert(user);
    }
    public Users[] GetUsers()
    {
        var users = _db.Query<Users>("SELECT * FROM Users");
        return users.ToArray();
    }
}
