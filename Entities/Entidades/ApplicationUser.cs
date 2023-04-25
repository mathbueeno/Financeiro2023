using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{									
									// Herança (Orientação a Objetos) - Você herda as caracteristicas de outras classes
									// No caso abaixo, está herdando do Entity FrameWork 
	public class ApplicationUser : IdentityUser
	{
		// Customização do identity do nosso banco de dados
		[Column("USR_CPF")]
		public string CPF { get; set; } // Criação de propriedade

	}
}
