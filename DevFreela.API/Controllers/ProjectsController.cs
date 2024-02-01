using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get (string query)
    {
        //buscra ou filtras
        return Ok();

    }
    [HttpGet("{id}")]
    public IActionResult GetByID(int id)
    {
        //buscra ou filtras
        return Ok();

    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectModel createProject)
    {
        if(createProject.Name.Length > 50) 
        {
            return BadRequest();
        }
        //buscra ou filtras
        return CreatedAtAction(nameof(GetByID), new { id = createProject.Id}, createProject);

    }

    [HttpPut("{id}")]
    public IActionResult Put(int id,[FromBody] UpdateProjectModel updateProject)
    {
        if (updateProject.Description.Length > 50)
        {
            return BadRequest();
        }
        //buscra ou filtras
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
       
        //buscra ou filtras
        return NoContent();

    }
}
