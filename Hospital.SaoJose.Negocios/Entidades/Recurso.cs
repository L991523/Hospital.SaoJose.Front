using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.SaoJose.Negocios
{
    [Table("Recurso")]
    public class Recurso
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Data de Inclusão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Custo")]
        [Required]
        public double Custo { get; set; }

        [Display(Name = "Informações Gerais")]
        public string InformacoesGerais { get; set; }

    }
}
