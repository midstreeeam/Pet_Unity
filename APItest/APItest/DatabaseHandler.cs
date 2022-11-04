using SQLite;
using System.Configuration;

public class DatabaseHandler
{

    private SQLiteConnection _db;

    public DatabaseHandler()
    {
        _db = new SQLiteConnection(ConfigurationManager.AppSettings["DBpath"]);
        _db.CreateTable<Stock>();
        _db.CreateTable<Valuation>();
    }
    public void AddStock(String symbol_name)
    {

        var stock = new Stock
        {
            Symbol = symbol_name
        };

        _db.Insert(stock);
    }
    public void GetStocks()
    {
        var stocks = _db.Query<Stock>("SELECT * FROM Stocks");

        foreach (var stock in stocks)
        {
            Console.WriteLine(stock.Symbol);
        }
    }
}
