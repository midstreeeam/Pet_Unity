using SQLite;

[Table("Stocks")]
public class Stock
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("symbol")]
    public string Symbol { get; set; }
}

[Table("Valuation")]
public class Valuation
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Indexed]
    [Column("stock_id")]
    public int StockId { get; set; }

    [Column("time")]
    public DateTime Time { get; set; }

    [Column("price")]
    public decimal Price { get; set; }
}