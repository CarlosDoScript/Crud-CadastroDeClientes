using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeCliente.Models
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public long Cpf { get; set; }
        public long Rg { get; set; }
        public long Telefone { get; set; }
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }
        public string Rua { get; set; }
        [Display(Name = "Número")]
        public int NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
