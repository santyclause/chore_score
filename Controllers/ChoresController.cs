namespace chore_score.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> GetAllChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetAllChores();
      return chores;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.CreateChore(choreData);
      return chore;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPut("{choreId}")]
  public ActionResult<Chore> UpdateChore(int choreId)
  {
    try
    {
      Chore chore = _choresService.UpdateChore(choreId);
      return chore;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{choreId}")]
  public ActionResult<string> DeleteChore(int choreId)
  {
    try
    {
      string message = _choresService.DeleteChore(choreId);
      return message;
    }
    catch (System.Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}