using Microsoft.AspNetCore.Identity;

namespace Saper.Models
{
	public class UsuariosApp : IdentityUser
	{
		public string PrimerNombre { get; set; }
		public string SegundoNombre { get; set; }

	}
}
