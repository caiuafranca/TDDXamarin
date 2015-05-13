using System;
using System.Collections.Generic;


namespace TDDOlaMundo
{
	public class Personagem
	{
		public int Life;
		public string nome;
		public string sexo;
		public int atack;
		public int vidas;
		public List<Itens> mochila = new List<Itens>();


		public Personagem(string nome){
			this.Life = 80;
			this.vidas = 5;
			this.atack = 10;
			this.mochila.Clear();
			selecionarPersonagem (nome);
		}

		public void selecionarPersonagem(string nome){

			if (nome == "CAMUNAKAIN") {
				this.nome = "CAMUNAKAIN";
				this.sexo = "Masculino";
				this.mochila.Add (new Itens ("Espada","Arma",10));
				this.mochila.Add (new Itens ("Macã","alimento",10));

			}else{				
				this.nome = "FEDJOLANE";
				this.sexo = "Feninino";
				this.mochila.Add (new Itens ("Chicote","Arma",10));
				this.mochila.Add (new Itens ("Macã","alimento",10));
			}
	}

		public void aumentarLife(Itens item){			
			this.Life += item.life;
		}

		public void adicionarItensMochila(Itens item){
			this.mochila.Add (item);
		}

	}

}

