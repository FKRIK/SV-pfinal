using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMC_aplication.Data;
using IMC_aplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMC_aplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context) =>
            _context = context;

        // ---- Métodos HTTP

        [HttpGet("listar")]
        public IActionResult Listar(){
            List<Usuario> Usuarios = _context.Usuarios.ToList();
            // return Usuarios.Count != 0 ? Ok(Usuarios) : NotFound();
            return Ok(Usuarios); // tirar este e colocar o de cima
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Usuario user){
            _context.Usuarios.Add(user);
            _context.SaveChanges();
            return Created("", user);
        }

        // [HttpPut]
        // public IActionResult Alterar(){
        //     return Ok();
        // }

        // [HttpDelete("deletar/{id}")]
        // public IActionResult Deletar(){
        //     return Ok();
        // }
    }
}