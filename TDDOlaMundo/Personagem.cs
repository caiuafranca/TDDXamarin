using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace TDDOlaMundo
{
	public class Personagem
	{
		public int Life;
		public int vidas;
		public List<Itens> mochila = new List<Itens>();


		public Personagem(){
			this.Life = 80;
			this.vidas = 5;
			this.mochila.Clear();
		}

		public void comer(Itens item){
			
			this.Life += item.life;

		}

	}

}

