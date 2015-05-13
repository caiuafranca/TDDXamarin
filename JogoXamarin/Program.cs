using System;
using TDDOlaMundo;

namespace JogoXamarin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Personagem personagem = new Personagem("CAMUNAKAIN");
	
			Console.WriteLine ("Seu Personagem é: " 
				+ personagem.nome + 
				" Poderoso Guerreiro.");
			Console.WriteLine ("Seu Personagem tem: " 
				+ personagem.Life + 
				" de Life");
			Console.WriteLine("Sua Mochila esta com " + 
				personagem.mochila.Count
				+ " Itens"); 
			Console.ReadKey ();
		}
	}
}
