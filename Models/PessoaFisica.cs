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

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " O tamanho de {0} deve estar entre {2} e {1}")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public long Cpf { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public long Rg { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public long Telefone { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} obrigatório")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " O tamanho de {0} deve estar entre {2} e {1}")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [Display(Name = "Número")]
        public int NumeroCasa { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " O tamanho de {0} deve estar entre {2} e {1}")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " O tamanho de {0} deve estar entre {2} e {1}")]
        public string Cidade { get; set; }
    }
}
