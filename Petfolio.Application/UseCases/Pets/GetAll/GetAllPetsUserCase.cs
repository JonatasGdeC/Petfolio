using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUserCase
{
  public ResponseAllPetJson Execute()
  {
    return new ResponseAllPetJson
    {
      Pets = new List<ResponseShortPetJson>
      {
        new ResponseShortPetJson
        {
          Id = 1,
          Name = "Charlie",
          Type = PetType.Dog
        }
      }
    };
  }
}
