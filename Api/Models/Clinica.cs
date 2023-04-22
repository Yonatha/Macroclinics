using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    [Table("clinica")]
    public class Clinica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public List<ClinicaUsuario> ClinicaUsuarios { get; set; }
    }
}