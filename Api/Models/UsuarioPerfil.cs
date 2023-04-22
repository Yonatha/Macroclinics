using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("usuario_perfil")]
    public class UsuarioPerfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}