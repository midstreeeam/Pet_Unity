internal class Program
{
    private static void Main(string[] args)
    {
        // Dbtest dtest = new Dbtest();
        // Dbtest.Run();
        DatabaseHandler dh = new DatabaseHandler();
        // dh.AddStock("test");
        dh.GetStocks();
    }
}