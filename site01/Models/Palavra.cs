using site01.Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Models
{
    public class Palavra
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [MaxLength(50, ErrorMessage ="O campo 'Nome' deve conter no máximo 50 caracteres")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        public byte? Nivel { get; set; }
    }
}
