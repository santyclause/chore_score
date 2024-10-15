namespace chore_score.Services;

public class ChoresService
{
  private readonly ChoresRepository _choresRepository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }

  internal List<Chore> GetAllChores()
  {
    List<Chore> chores = _choresRepository.GetAllChores();
    return chores;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _choresRepository.CreateChore(choreData);
    return chore;
  }

  internal Chore UpdateChore(int choreId)
  {
    Chore chore = _choresRepository.UpdateChore(choreId);
    return chore;
  }

  internal string DeleteChore(int choreId)
  {
    string message = _choresRepository.DeleteChore(choreId);
    return message;
  }
}