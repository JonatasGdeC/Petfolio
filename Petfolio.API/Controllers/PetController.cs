using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
  [HttpPost]
  [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
  public IActionResult Register([FromBody] RequestRegisterPetJson request)
  {
    var response = new RegisterPetUserCase().Execute(request);
    return Created(string.Empty, response);
  }
}
