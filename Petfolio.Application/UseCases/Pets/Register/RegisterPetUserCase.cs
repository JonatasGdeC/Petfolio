using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUserCase
{
  public ResponseRegisterPetJson Execute(RequestPetJson request)
  {
    return new ResponseRegisterPetJson
    {
      Id = 1,
      Name = request.Name,
    };
  }
}
