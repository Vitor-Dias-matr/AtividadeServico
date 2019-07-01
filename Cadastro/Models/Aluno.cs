using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    public class Aluno : EntityBase
    {
        [Required(ErrorMessage = "Campo obrigatório*")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Data De nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Campo Obrigatorio")]
        public string Data_de_Nascimento { get; set; }

        //[StringLeength]
        //[RegularExpression("[F-M])"]

        [Required(ErrorMessage = "Campo obrigatório*")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
      
    }
}
