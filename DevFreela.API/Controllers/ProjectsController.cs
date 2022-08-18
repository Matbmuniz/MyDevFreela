using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        //api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        //api/projects/599
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectsModel createProject)
        {
            if(createProject.Title.Length > 50)  return BadRequest();

            //Cadastrar
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);

        }

        //api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectsModel updateProject)
        {
            if (updateProject.Description.Length > 50) return BadRequest();

            //Atualizar o objeto

            return NoContent();
        }

        //api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retorn NotFound

            //Remover
            
            return NoContent();
        }
    }
}
