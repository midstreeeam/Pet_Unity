internal class Program
{
    private static void Main(string[] args)
    {
        DatabaseHandler dh = new DatabaseHandler();
        Users[] users = dh.GetUsers();
        foreach (Users u in users)
        {
            Console.Write(u.UserName+"\t"+u.PetId.ToString());
        }
    }

    private static void Test()
    {
        DatabaseHandler dh = new DatabaseHandler();
        dh.AddUser("bob", -1);
    }
}