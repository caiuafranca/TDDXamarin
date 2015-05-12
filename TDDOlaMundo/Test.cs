using NUnit.Framework;
using System;

namespace TDDOlaMundo
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void CriarPersonagemComLife80()
		{
			Personagem personagem = new Personagem ();

			Assert.AreEqual (80, personagem.Life);
		}

		[Test ()]
		public void CriarPersonagemcom5vidas(){
		
			Personagem personagem = new Personagem ();
			Assert.AreEqual (5, personagem.vidas);
		}
		[Test ()]
		public void MochilaVazia(){
			Personagem personagem = new Personagem ();
			Assert.IsEmpty(personagem.mochila);
		}

		[Test ()]
		public void AdicionarItensAMochila(){
			Personagem personagem = new Personagem ();
			personagem.mochila.Add (new Itens ("faca", "Arma", 10));
			Assert.IsNotEmpty (personagem.mochila);
		}

		[Test ()]
		public void AoComerAlimentoAumentaoLife(){
			Personagem personagem = new Personagem ();
			personagem.mochila.Add(new Itens("pera","alimento", 5));
			personagem.mochila.Add(new Itens("Fruta Sagrada","alimento", 30));
			var lifeAtual = personagem.Life;
			personagem.comer (new Itens("pera","alimento",5));
			Assert.IsTrue (lifeAtual < personagem.Life);
		}

	}
}

