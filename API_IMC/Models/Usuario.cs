using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC_aplication.Models
{
    public class Usuario
    {
        public Usuario(){
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data_Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}