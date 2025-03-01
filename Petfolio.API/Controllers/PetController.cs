using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
  [HttpPost]
  [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
  public IActionResult Register([FromBody] RequestPetJson request)
  {
    var response = new RegisterPetUserCase().Execute(request);
    return Created(string.Empty, response);
  }

  [HttpPut]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
  {
    var userCase = new UpdatePetUserCase();
    userCase.Execute(id, request);
    return NoContent();
  }
}
