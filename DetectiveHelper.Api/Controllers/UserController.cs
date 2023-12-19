using DetectiveHelper.Dto.Internal;
using DetectiveHelper.Facade.Interface.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserFacade _userFacade;

    public UserController(IUserFacade userFacade)
    {
        _userFacade = userFacade;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
    {
        var users = await _userFacade.GetAllUsers();
        return Ok(users);
    }

    // Adicione outros métodos de ações, como POST, PUT, DELETE, conforme necessário
}
