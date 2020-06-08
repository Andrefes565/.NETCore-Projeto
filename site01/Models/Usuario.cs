using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Models
{
    public class Usuario
    {
        [EmailAddress(ErrorMessage = "Digite um Email válido")] 
        [Required(ErrorMessage = "O campo 'Email' é obrigatório")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório")] 
        public string Senha { get; set; }
    }
}
