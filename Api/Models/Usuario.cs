using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public string Email { get; set; }
        [JsonIgnore]
        public string Senha { get; set; }
        public List<UsuarioPerfil>? UsuarioPerfis { get; set; }
        public List<ClinicaUsuario> ClinicaUsuarios { get; set; }
    }
}