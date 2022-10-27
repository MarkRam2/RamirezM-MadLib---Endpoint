// Mark A Ramirez
// 10/26/2022
// MadLib 
// this code will take you input using the url to make a prefabricated story 
// Peer Review: Arely Martinez - The program does what is entended. If i input a 
// adj it shows up in the proper field, this applys for every other input. Also 
// Mark's code looks very clean. 



using Microsoft.AspNetCore.Mvc;

namespace RamirezM_MadLib___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
/*{Fadjective}/{creature}/{gender}/{Event}/{Fverb}/
{Sadjective}/{Fnoun}/{Sverb}/{Tadjective}/{Snoun}*/
[HttpGet]
[Route("Madness/{Fadjective}/{creature}/{gender}/{Event}/{Fverb}/{Sverb}/{Sadjective}/{Fnoun}/{Tadjective}/{Snoun}")]

public string pogger(string Fadjective, string creature, string gender, string Event, string Fverb, string Sverb, string Sadjective, string Fnoun, string Tadjective, string Snoun)
{

return $" The {Fadjective} {creature} felt sad so {gender} decided they were going to set up {Event} after {gender} {Fverb} the {Sadjective} {Fnoun} filled with {Sverb} {gender} then decided to invite all the {Tadjective} {Snoun} to the building ";

}

}
