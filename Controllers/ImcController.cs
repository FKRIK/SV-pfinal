using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMC_aplication.Data;
using IMC_aplication.Models;
using IMC_aplication.Utils;
using Microsoft.AspNetCore.Mvc;

namespace IMC_aplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImcController : ControllerBase
    {
        private readonly DataContext _context;

        public ImcController(DataContext context) =>
            _context = context;

        // ---- Métodos HTTP

        [HttpGet("listar")]
        public IActionResult Listar(){
            List<Imc> Imcs = _context.Imcs.ToList();// return Imcs.Count != 0 ? Ok(Imcs) : NotFound();
            return Ok(Imcs); // tirar este e colocar o de cima
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Imc imcs){
            // Variável temporária
            double holder = 0;
            // Faz o cálculo
            holder = Calculos.CalcularImc(imcs.Peso, imcs.Altura);
            // Guarda na propriedade do objeto
            imcs.Imcc = holder;

            string holder2= "";
            holder2 = Calculos.ClassificarImc(imcs.Imcc);
            imcs.Classificacao = holder2;


            _context.Imcs.Add(imcs);
            _context.SaveChanges();
            return Created("", imcs);
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