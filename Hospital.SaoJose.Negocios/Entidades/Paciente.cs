using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital.SaoJose.Negocios
{
    [Table("Paciente")]
    public class Paciente
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required]
        public string Cpf { get; set; }

        [Display(Name = "Data de Internação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInternacao { get; set; }

        [Display(Name = "Alergias")]
        public string Alergias { get; set; }

        [UIHint("_Exames")]
        public virtual ICollection<Exame> Exames { get; set; }

        [UIHint("_Laudos")]
        public virtual ICollection<Laudo> Laudos { get; set; }

        public void AtualizaDadosPaciente(Paciente paciente) { }

        public void RemovePacienteListaPendentes(Paciente paciente) { }
    }
}
