using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
	// Classe de notificação - Responsável por retornar notificações, validações e mensagens para o front. 
	public class Notificacao
	{

		public Notificacao()  // método construtor - é executado toda vez que o objeto é iniciado. No caso, irá notificar sempre que o objeto for chamado
		{
			notificacoes = new List<Notificacao>();
		}

		// propriedades

		[NotMapped]
		public string NomePropriedade { get; set; }

		[NotMapped]
		public string Mensagem { get; set; }

		[NotMapped]

		public List<Notificacao> notificacoes;



		// Método para validação de strings
		public bool ValidarPropriedadeString (string valor, string nomePropriedade)
		{
			// SE string valor for nula ou espaço branco OU string nomePropriedade for nulo ou espaço branco
			if (string.IsNullOrWhiteSpace(valor)) || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				notificacoes.Add(new Notificacao
				{
					Mensagem = "Campo obrigatório",
					NomePropriedade= nomePropriedade
				});
				return false;
			}
			return true;
		}

		// Método para validação de inteiros
		public bool ValidarPropriedadeInt(int valor, int nomePropriedade)
		{
			// SE valor for MENOR (<) que 1 OU string nomePropriedade for nulo ou espaço branco
			// valor < 1 - pois se for maior que 1, logo possui um número ali elencado

			if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				notificacoes.Add(new Notificacao
				{
					Mensagem = "Campo obrigatório",
					NomePropriedade = "nomePropriedade"
				});
				return false;
			}
			return true;
		}

	}
}
