using site01.Database;
using site01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Library.Validation
{
    public class UnicoNomePalavraAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra;
            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));

            //verificar se Já existe no banco 1 registro
            // - verificar se o nome existe
            // - verificar se o id é o mesmo do resgistro no banco
            var palavraBanco = _db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if(palavraBanco == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("A palavra " + palavra.Nome + " já está sendo utilizada");
            }
        }
    }
}
