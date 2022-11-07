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
    public Users[] GetAllUsers()
    {
        var users = _db.Query<Users>("SELECT * FROM Users");
        return users.ToArray();
    }
    public Users GetUserById(int Id)
    {
        return _db.Table<Users>().Where(t => t.Id == Id).ToList()[0];
    }
    public void AddHistory(int user_id, int pet_id, string action_type)
    {
        var history = new History
        {
            UserId = user_id,
            PetId = GetUserById(user_id).PetId,
            ActionType = action_type,
            StartTime = DateTime.Now
        };
        _db.Insert(history);
    }
}
