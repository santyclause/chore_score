namespace chore_score.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Chore> GetAllChores()
  {
    string sql = "SELECT * FROM chores;";
    List<Chore> chores = _db.Query<Chore>(sql).ToList();
    return chores;
  }

  internal Chore CreateChore(Chore choreData)
  {
    string sql = "INSERT INTO chores(name, description) VALUES(@Name, @Description); SELECT * FROM chores WHERE id = LAST_INSERT_ID();";

    Chore chore = _db.Query<Chore>(sql, choreData).FirstOrDefault();
    return chore;
  }

  internal Chore UpdateChore(int choreId)
  {
    string sql = "UPDATE chores SET isComplete = true WHERE id = @choreId";

    Chore chore = _db.Query<Chore>(sql).FirstOrDefault();
    return chore;
  }

  internal string DeleteChore(int choreId)
  {
    string sql = "DELETE FROM chores WHERE id = @choreId";

    string message = $"Chore with id {choreId} was deleted.";
    return message;
  }
}