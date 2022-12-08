using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMC_aplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMC_aplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult Listar(){
            return Ok();
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(){
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar(){
            return Ok();
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Deletar(){
            return Ok();
        }
    }
}