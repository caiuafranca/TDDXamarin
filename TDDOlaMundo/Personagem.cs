using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace TDDOlaMundo
{
	public class Personagem
	{
		public int Life;
		public int atack;
		public int vidas;
		public List<Itens> mochila = new List<Itens>();


		public Personagem(){
			this.Life = 80;
			this.vidas = 5;
			this.atack = 10;
			this.mochila.Clear();
		}

		public void aumentarLife(Itens item){			
			this.Life += item.life;
		}

		public void adicionarItensMochila(Itens item){
			this.mochila.Add (item);
		}

	}

}

