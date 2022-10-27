/*Madeline Gowan
10-26-2022
Odd or Even - Endpoint
Create a web api that, when a number is entered into the URL, will return whether the number is odd or even

Peer review: Christopher Prado 26OCT22: I enjoyed running this program on the postman. I chose my favorite number and it guessed even correctly. The program even provided a link so that I could utilize a 'cheat sheet' if necessary. Great work! Go Slytherin house
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMOddEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddEvenController : ControllerBase
{

//cheat sheet: https://localhost:xxxx/OddEven/Numbers/x                                                                                                                                                                     
    [HttpGet]
    [Route("Numbers/{input}")]
    public string Numbers(int input){
        if(input % 2 == 0){
            return "This number is even";
        }else{
            return "This number is odd";
        }
    }
}