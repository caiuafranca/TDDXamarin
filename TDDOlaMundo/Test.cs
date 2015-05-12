using NUnit.Framework;
using System;

namespace TDDOlaMundo
{
	[TestFixture ()]
	public class Test
	{
		Personagem personagem;

		[SetUp()]
		public void CriarPersonagem(){
			personagem = new Personagem ();
		}

		[Test ()]
		public void CriarPersonagemComLife80()
		{
			//Personagem personagem = new Personagem ();

			Assert.AreEqual (80, personagem.Life);
		}

		[Test ()]
		public void CriarPersonagemcom5vidas(){
			Assert.AreEqual (5, personagem.vidas);
		}
		[Test ()]
		public void MochilaVazia(){
			Assert.IsEmpty(personagem.mochila);
		}

		[Test ()]
		public void AdicionarItensAMochila(){

			personagem.adicionarItensMochila (new Itens ("faca", "Arma", 10));
			personagem.adicionarItensMochila (new Itens ("Espada Vorpal", "Arma", 100));
			personagem.adicionarItensMochila (new Itens ("Maçã", "Alimento", 10));
			personagem.adicionarItensMochila (new Itens ("Fruta Sagrada", "Alimento", 100));

			Assert.IsNotEmpty (personagem.mochila);
		}

		[Test ()]
		public void AoComerAlimentoAumentaoLife(){
			
			personagem.mochila.Add(new Itens("pera","alimento", 5));
			personagem.mochila.Add(new Itens("Fruta Sagrada","alimento", 30));

			var lifeAtual = personagem.Life;

			personagem.aumentarLife (new Itens("pera","alimento",5));

			Assert.IsTrue (lifeAtual < personagem.Life);
		}

	}
}

