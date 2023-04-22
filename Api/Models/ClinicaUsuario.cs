using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("clinica_usuario")]
    public class ClinicaUsuario
    {
        public Guid ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}