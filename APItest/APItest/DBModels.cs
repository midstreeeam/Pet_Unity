using SQLite;

[Table("Users")]
public class Users
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("user_name"), NotNull]
    public string UserName { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("gender")]
    public string Gender { get; set; }

    [Column("pet_id"), NotNull]
    public int PetId { get; set; }
}

[Table("Pets")]
public class Pets
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }
}

[Table("Animations")]
public class Animations
{
    [PrimaryKey,AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("name"),NotNull]
    public string Name { get; set; }
}

[Table("History")]
public class History
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("user_id"), NotNull]
    public int UserId { get; set; }

    [Column("pet_id"), NotNull]
    public int PetId { get; set; }

    [Column("action_type"), NotNull]
    public string ActionType { get; set; }

    [Column("start_time"),NotNull]
    public DateTime StartTime { get; set; }

    [Column("end_time")]
    public DateTime EndTime { get; set; }
}