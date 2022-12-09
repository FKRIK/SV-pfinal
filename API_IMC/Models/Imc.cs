using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMC_aplication.Models
{
    public class Imc
    {
        public Imc(){
        }
        [Key]
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Imcc { get; set; }
        public string Classificacao { get; set; }
        // public int UsuarioId { get; set; }
        // public Usuario Usuario { get; set; }
    }

    
}