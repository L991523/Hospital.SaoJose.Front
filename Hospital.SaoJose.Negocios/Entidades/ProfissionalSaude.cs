using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.SaoJose.Negocios
{
    [Table("ProfissionalSaude")]
    public class ProfissionalSaude
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Formação")]
        public string Formacao { get; set; }

        public void DisparaNotificacao(){ }
    }
}
