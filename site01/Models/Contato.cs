using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")] //não pode ficar em branco
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo 'Email' deve conter no máximo 70 caracteres")]
        [EmailAddress(ErrorMessage ="Digite um Email válido")] // validação do Email
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Assunto' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo 'Assunto' deve conter no máximo 70 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo 'Menssagem' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O campo 'Menssagem' deve conter no máximo 70 caracteres")]
        public string Menssagem { get; set; }

    }
}
